using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClicker
{
    // Formul pentru magazinul de Rebirth, unde jucatorii pot cheltui punctele de Rebirth pentru a viziona un videoclip secret
    public partial class RebirthShop : Form
    {
        private bool videoInitializat = false;
        public RebirthShop()
        {
            InitializeComponent();

            label1.ForeColor = Color.FromArgb(0, 0, 0);
        }
        // Butonul pentru a inchide magazinul si a reveni la ecranul principal
        private void butonInapoi_Click(object sender, EventArgs e)
        {
            CookieClicker.Form1.Instanta.InchideRebirthShop();
        }
        // Butonul pentru a viziona videoclipul secret, care verifica daca jucatorul are suficiente puncte de Rebirth, apoi incarca videoclipul in WebView2
        private async void button1_Click(object sender, EventArgs e)
        {
            if (Form1.Instanta.rebirthpoints >= 1000)
            {
                Form1.Instanta.rebirthpoints -= 1000;

                string caleVideo = @"D:\c++\cookieclicker-cica\CookieClicker\CookieClicker\Secret.mp4";

                if (System.IO.File.Exists(caleVideo))
                {
                    await webView21.EnsureCoreWebView2Async(null);

                    if (!videoInitializat)
                    {
                        webView21.CoreWebView2.WebMessageReceived += WebView21_WebMessageReceived;

                        await webView21.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(@"
                    window.addEventListener('keydown', function(event) {
                        if (event.key === 'Escape') {
                            window.chrome.webview.postMessage('INCHIDE_VIDEO');
                        }
                    });
                ");

                        videoInitializat = true;
                    }

                    webView21.Visible = true;
                    webView21.Dock = DockStyle.Fill;
                    webView21.BringToFront();
                    webView21.CoreWebView2.Navigate(caleVideo);
                }
                else
                {
                    MessageBox.Show("Fisierul nu a fost gasit!");
                }
            }
            else
            {
                MessageBox.Show("Nu ai destule Rebirth Points! Ai nevoie de 1000.");
            }
        }
        // Evenimentul pentru a primi mesaje de la WebView2, care inchide videoclipul atunci cand jucatorul apasa tasta Escape
        private void WebView21_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            string mesaj = e.TryGetWebMessageAsString();

            if (mesaj == "INCHIDE_VIDEO")
            {
                webView21.CoreWebView2.Navigate("about:blank");
                webView21.Visible = false;
            }
        }
        // Suprascrierea metodei ProcessCmdKey pentru a detecta apasarea tastei Escape si a inchide videoclipul daca este vizibil
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                if (webView21.Visible)
                {
                    webView21.CoreWebView2.Navigate("about:blank");

                    webView21.Visible = false;

                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}

