using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class Form1 : Form
    {
        //variabilele principale ale jocului
        public double totalClicks = 0;
        public double Multi = 1;
        public double click = 1;
        public double autoCookies = 0;
        public double manualcps = 0;
        //variabile pentru rebirth
        public int rebirths = 0;
        public int rebirthpoints = 0;
        public double pretrebirth = 1e3;
        // Lista pentru textul plutitor
        List<Utilitare.TextPlutitor> textePlutitoare = new List<Utilitare.TextPlutitor>();
        // Ferestrele pentru magazine
        ClickShop fereastraClickShop = null;
        MultiShop fereastraMultiShop = null;
        AutoShop fereastraAutoShop = null;
        RebirthShop fereastraRebirth = null;
        //variabile pentru click cooldown
        DateTime ultimuclick = DateTime.MinValue;
        int cooldownclickms = 150;
        //variabila pentru sunet click ca sa sa nu se reseteze la fiecare click
        System.Media.SoundPlayer playerSunetClick = new System.Media.SoundPlayer(@"D:\c++\cookieclicker-cica\CookieClicker\CookieClicker\sunet_click.wav");
        private bool sunetClickActivat = true;
        //instanta pentru a putea fi accesata din alte formuri
        public static Form1 Instanta;


        //constructorul formului
        public Form1()
        {
            InitializeComponent();
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
        ?.SetValue(panelshop, true, null);
            Instanta = this;
            this.DoubleBuffered = true;
            this.SetStyle(
        ControlStyles.AllPaintingInWmPaint |
        ControlStyles.UserPaint |
        ControlStyles.OptimizedDoubleBuffer,
        true);

            this.UpdateStyles();
        }
        // Importul pentru functia mciSendString din winmm.dll pentru a putea reda muzica de fundal
        [System.Runtime.InteropServices.DllImport("winmm.dll")]
        private static extern long mciSendString(string command, string returnString, int returnSize, IntPtr hwndCallback);
        // Functia pentru a porni muzica de fundal si a seta volumul initial
        private void PornesteMuzicaFundal()
        {
            string caleMp3 = @"D:\c++\cookieclicker-cica\CookieClicker\CookieClicker\muzica.mp3";

            try
            {
                mciSendString("open \"" + caleMp3 + "\" type mpegvideo alias MuzicaFundal", null, 0, IntPtr.Zero);

                mciSendString("play MuzicaFundal repeat", null, 0, IntPtr.Zero);

                int volumInitial = trackBarVolum.Value * 10;
                mciSendString("setaudio MuzicaFundal volume to " + volumInitial, null, 0, IntPtr.Zero);
            }
            catch
            {
            }
        }
        //volume meter pentru a schimba volumul muzicii de fundal
        private void trackBarVolum_Scroll(object sender, EventArgs e)
        {
            int volumMCI = trackBarVolum.Value * 10;
            mciSendString("setaudio MuzicaFundal volume to " + volumMCI, null, 0, IntPtr.Zero);
        }
        //buton pentru a activa/dezactiva sunetul de click
        private void buttonMuteClick_Click(object sender, EventArgs e)
        {
            sunetClickActivat = !sunetClickActivat;
            if (sunetClickActivat)
            {
                buttonMuteClick.Text = "🔊 Click Sound: ON";
                buttonMuteClick.BackColor = Color.FromArgb(45, 110, 185);
            }
            else
            {
                buttonMuteClick.Text = "🔇 Click Sound: OFF";
                buttonMuteClick.BackColor = Color.FromArgb(100, 100, 100);
            }
        }
        // Suprascrierea CreateParams pentru a adauga stilul WS_EX_COMPOSITED si a reduce flicker-ul
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CatalogUpgradeuri.ConstruiesteCatalogul();

            Utilitare.Load(this);

            ActualizeazaInterfata();

            RebirthButton.FlatStyle = FlatStyle.Flat;
            RebirthButton.FlatAppearance.BorderSize = 0;

            panelshop.Visible = false;
            buttonCloseShop.Visible = false;
            PornesteMuzicaFundal();
        }
        // Salvarea progresului la inchiderea jocului
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utilitare.Save(this);
        }
        // Functia pentru a cumpara un upgrade
        public bool CumparaUpgrade(Upgrade upg)
        {
            if (totalClicks >= upg.PretCurent)
            {
                totalClicks -= upg.PretCurent;
                upg.Nivel++;

                if (upg.Tip == TipUpgrade.Click) click += upg.Bonus;
                if (upg.Tip == TipUpgrade.Multi) Multi += upg.Bonus;
                if (upg.Tip == TipUpgrade.Auto) autoCookies += upg.Bonus;

                upg.PretCurent *= 2;

                ActualizeazaInterfata();
                return true;
            }

            MessageBox.Show("Nu ai destule prajituri!", "Atentie");
            return false;
        }
        // Functia pentru a cumpara un rebirth
        public bool CumparaRebirth()
        {
            if (totalClicks >= pretrebirth)
            {
                totalClicks = 0; Multi = 1; click = 1; autoCookies = 0;
                rebirths++;
                rebirthpoints += 1;
                pretrebirth *= 10;


                CurataListaPreturi();
                fereastraClickShop = null;
                fereastraMultiShop = null;
                fereastraAutoShop = null;

                panelshop.Controls.Clear();
                panelshop.Visible = false;
                ActualizeazaInterfata();
                return true;
            }
            MessageBox.Show("Nu ai destule prajituri pentru a face un rebirth!", "Atentie");
            return false;
        }
        // Buton pentru a reseta tot progresul
        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResult raspuns = MessageBox.Show(
                "Esti sigur ca vrei un Hard Reset? Nu exista cale de intoarcere!",
                "Atentie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (raspuns == DialogResult.Yes)
            {
                totalClicks = 0; Multi = 1; click = 1; autoCookies = 0;
                rebirths = 0; rebirthpoints = 0; pretrebirth = 1e3;

                CurataListaPreturi();
                fereastraClickShop = null;
                fereastraMultiShop = null;
                fereastraAutoShop = null;

                panelshop.Controls.Clear();
                panelshop.Visible = false;
                buttonCloseShop.Visible = false;
                ActualizeazaInterfata();
            }
        }
        // Functia pentru a reseta preturile si nivelele upgrade-urilor la 0 dupa un rebirth sau hard reset
        private void CurataListaPreturi()
        {
            foreach (var upg in CatalogUpgradeuri.listaClick)
            {
                upg.PretCurent = upg.PretDeBaza;
                upg.Nivel = 0;
            }
            foreach (var upg in CatalogUpgradeuri.listaMulti)
            {
                upg.PretCurent = upg.PretDeBaza;
                upg.Nivel = 0;
            }
            foreach (var upg in CatalogUpgradeuri.listaAuto)
            {
                upg.PretCurent = upg.PretDeBaza;
                upg.Nivel = 0;
            }
        }
        // Functia pentru a adauga cookie-uri la numar dupa un click
        private void AdaugaCookie()
        {
            totalClicks += (click * Multi);
            manualcps += (click * Multi);
            ActualizeazaInterfata();
        }
        // Functia pentru a actualiza interfata cu noile valori
        public void ActualizeazaInterfata()
        {
            label1.Text = "Cookies: " + Utilitare.FormateazaNumar(totalClicks);
            label3.Text = "Rebirth points: " + Utilitare.FormateazaNumar(rebirthpoints);
            RebirthPrice.Text = "Pret Rebirth: " + Utilitare.FormateazaNumar(pretrebirth) + " Cookies";
            RebirthButton.BackColor = totalClicks >= pretrebirth ? Color.Green : Color.Red;
        }
        // Timer pentru a adauga cookie-uri automate si a actualiza CPS-ul
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (autoCookies > 0) { totalClicks += autoCookies; if (fereastraRebirth != null) return; ActualizeazaInterfata(); }
            label2.Text = "CPS: " + Utilitare.FormateazaNumar(autoCookies + manualcps);
            manualcps = 0;
        }
        // Functia pentru a detecta click-urile pe cookie si a adauga cookie-uri in consecinta, precum si pentru a reda sunetul de click
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if ((DateTime.Now - ultimuclick).TotalMilliseconds < cooldownclickms || BackgroundImage == null) return;

            float scala = Math.Min((float)ClientSize.Width / BackgroundImage.Width, (float)ClientSize.Height / BackgroundImage.Height);
            float razaCookie = (BackgroundImage.Width * scala * 0.23f) / 2f;

            float distX = e.X - (ClientSize.Width * 0.50f);
            float distY = e.Y - (ClientSize.Height * 0.34f);

            if (Math.Sqrt((distX * distX) + (distY * distY)) <= razaCookie)
            {
                ultimuclick = DateTime.Now;
                AdaugaCookie();
                textePlutitoare.Add(new Utilitare.TextPlutitor { X = e.X, Y = e.Y, Text = "+" + Utilitare.FormateazaNumar(click * Multi) });
            }
            if (sunetClickActivat){
                try { playerSunetClick.Play(); } catch { } 
            }
        }
        // Functia pentru a desena cate cookie-uri au fost adaugate la fiecare click
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (BackgroundImage == null) return;
            using (Font fontPlutitor = new Font("Arial", 16, FontStyle.Bold))
            {
                foreach (var txt in textePlutitoare)
                {
                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(txt.Alpha, Color.Black)))
                        e.Graphics.DrawString(txt.Text, fontPlutitor, brush, txt.X, txt.Y);
                }
            }
        }
        // Timer pentru a anima textul plutitor si a-l face sa dispara treptat
        private void timer2_Tick(object sender, EventArgs e)
        {
            bool textAdisparut = false;

            for (int i = textePlutitoare.Count - 1; i >= 0; i--)
            {
                textePlutitoare[i].Y -= 2f;
                textePlutitoare[i].Alpha -= 10;

                if (textePlutitoare[i].Alpha <= 0)
                {
                    textePlutitoare.RemoveAt(i);
                    textAdisparut = true;
                }
            }

            if (textePlutitoare.Count > 0)
            {
                float minX = 99999, minY = 99999, maxX = 0, maxY = 0;

                foreach (var txt in textePlutitoare)
                {
                    if (txt.X < minX) minX = txt.X;
                    if (txt.Y < minY) minY = txt.Y;
                    if (txt.X > maxX) maxX = txt.X;
                    if (txt.Y > maxY) maxY = txt.Y;
                }

                Rectangle zonaAnimatie = new Rectangle(
                    (int)minX - 100,
                    (int)minY - 25,
                    (int)(maxX - minX) + 200,
                    (int)(maxY - minY) + 50
                );

                this.Invalidate(zonaAnimatie);
            }
            else if (textAdisparut)
            {
                this.Invalidate();
            }
        }
        // Suprascrierea metodei OnResize pentru a invalida form-ul si a forta redesenarea la redimensionare, astfel incat textul plutitor sa se pozitioneze corect
        private void Form1_Resize(object sender, EventArgs e) { Invalidate(); }
        // Functia pentru a deschide o form in panelul dedicat magazinului
        private void DeschideInPanel(Form shopForm)
        {
            panelshop.SuspendLayout();

            panelshop.Controls.Clear();
            shopForm.TopLevel = false;
            shopForm.FormBorderStyle = FormBorderStyle.None;
            shopForm.Dock = DockStyle.Fill;
            panelshop.Controls.Add(shopForm);
            shopForm.Show();
            panelshop.Visible = true;
            buttonCloseShop.Visible = true;
            panelshop.ResumeLayout();
        }
        // Functiile pentru a deschide fiecare magazin in parte, verificand daca fereastra exista deja pentru a nu crea multiple instante
        private void ClickShop_Click(object sender, EventArgs e)
        {
            if (fereastraClickShop == null || fereastraClickShop.IsDisposed)
                fereastraClickShop = new ClickShop();
            DeschideInPanel(fereastraClickShop);
        }
        private void MultiShop_Click(object sender, EventArgs e)
        {
            if (fereastraMultiShop == null || fereastraMultiShop.IsDisposed)
                fereastraMultiShop = new MultiShop();
            DeschideInPanel(fereastraMultiShop);
        }
        private void AutoShop_Click_1(object sender, EventArgs e)
        {
            if (fereastraAutoShop == null || fereastraAutoShop.IsDisposed)
                fereastraAutoShop = new AutoShop();
            DeschideInPanel(fereastraAutoShop);
        }
        // Functia pentru a deschide magazinul de rebirth, care este putin diferit deoarece are un panel dedicat in form    
        private void butonRebirthShop_Click(object sender, EventArgs e)
        {
            if (fereastraRebirth == null || fereastraRebirth.IsDisposed) fereastraRebirth = new RebirthShop();
            panelRebirth.Controls.Clear();
            fereastraRebirth.TopLevel = false; fereastraRebirth.FormBorderStyle = FormBorderStyle.None; fereastraRebirth.Dock = DockStyle.Fill;
            panelRebirth.Controls.Add(fereastraRebirth); fereastraRebirth.Show();
            panelRebirth.BringToFront(); panelRebirth.Visible = true;
        }
        // Functia pentru a inchide magazinul deschis in panelul dedicat
        private void buttonCloseShop_Click_1(object sender, EventArgs e)
        {
            panelshop.Controls.Clear();
            panelshop.Visible = false;
            buttonCloseShop.Visible = false;
        }
        // Functia pentru a inchide magazinul de rebirth
        public void InchideRebirthShop()
        {
            panelRebirth.Controls.Clear();
            panelRebirth.Visible = false;
            fereastraRebirth = null;
        }
        // Functia pentru a cumpara un rebirth, apelata din butonul din RebirthShop
        private void RebirthButton_Click(object sender, EventArgs e) { CumparaRebirth(); }


    }
}