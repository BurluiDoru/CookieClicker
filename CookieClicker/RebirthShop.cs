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
    public partial class RebirthShop : Form
    {
        public RebirthShop()
        {
            InitializeComponent();
        }

        private void butonInapoi_Click(object sender, EventArgs e)
        {
            CookieClicker.Form1.Instanta.InchideRebirthShop();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (Form1.Instanta.rebirthpoints >= 1000)
            {
                // Scadem pretul din variabila aflata in Form1
                Form1.Instanta.rebirthpoints -= 1000;

                // Nu uita sa actualizezi si textul de pe ecran cu noile puncte
                // labelPuncteRebirth.Text = "Puncte: " + totalRebirthPoints.ToString();

                string caleVideo = @"D:\c++\cookieclicker-cica\CookieClicker\CookieClicker\Secret.mp4";

                if (System.IO.File.Exists(caleVideo))
                {
                    await webView21.EnsureCoreWebView2Async(null);

                    webView21.Visible = true;
                    webView21.Dock = DockStyle.Fill;
                    webView21.BringToFront();

                    // Rulam videoclipul
                    webView21.CoreWebView2.Navigate(caleVideo);
                }
                else
                {
                    MessageBox.Show("Fisierul nu a fost gasit!");
                }
            }
            else
            {
                // Afisam un mesaj de eroare daca este prea sarac
                MessageBox.Show("Nu ai destule Rebirth Points! Ai nevoie de 1000.");
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Verificam daca tasta apasata este ESC
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

