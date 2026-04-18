using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq; 
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class Form1 : Form
    {
       
        // Variabilele jocului
        public double totalClicks = 0;
        public double Multi = 1;
        public double click = 1;
        public double autoCookies = 0;
        public double manualcps = 0;

        public int rebirths = 0;
        public int rebirthpoints = 0;
        public double pretrebirth = 1e3;

        List<Utilitare.TextPlutitor> textePlutitoare = new List<Utilitare.TextPlutitor>();

        ClickShop fereastraClickShop = null;
        MultiShop fereastraMultiShop = null;
        AutoShop fereastraAutoShop = null;
        RebirthShop fereastraRebirth = null;

        DateTime ultimuclick = DateTime.MinValue;
        int cooldownclickms = 50;
        // Memorie pentru a tine poza in siguranta cand tragem de ecran
        private Image memorieFundal;

        public static Form1 Instanta;

        public Form1()
        {
            InitializeComponent();
            Instanta = this;
            this.DoubleBuffered = true;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Activam WS_EX_COMPOSITED
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
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utilitare.Save(this);
        }

        // --- FUNCTIA UNIVERSALA DE CUMPARARE ---
        public bool CumparaUpgrade(Upgrade upg)
        {
            if (totalClicks >= upg.PretCurent)
            {
                totalClicks -= upg.PretCurent;
                upg.Nivel++;

                // Aici verificam eticheta si dam bonusul corect
                if (upg.Tip == TipUpgrade.Click) click += upg.Bonus;
                if (upg.Tip == TipUpgrade.Multi) Multi += upg.Bonus;
                if (upg.Tip == TipUpgrade.Auto) autoCookies += upg.Bonus;

                upg.PretCurent *= 2; // pretul se dubleaza dupa fiecare cumparare

                ActualizeazaInterfata();
                return true;
            }

            MessageBox.Show("Nu ai destule prajituri!", "Atentie");
            return false;
        }

        // --- BUTOANE DE RESET SI REBIRTH ---
        public bool CumparaRebirth()
        {
            if (totalClicks >= pretrebirth)
            {
                totalClicks = 0; Multi = 1; click = 1; autoCookies = 0;
                rebirths++; rebirthpoints += 1;
                pretrebirth *= 10;

                // Curatam listele la valorile de inceput
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

        private void CurataListaPreturi()
        {
            // O singura functie care reseteaza toate preturile din toate magazinele
            foreach (var upg in CatalogUpgradeuri.listaClick) { upg.PretCurent = upg.PretDeBaza; upg.Nivel = 0; }
            foreach (var upg in CatalogUpgradeuri.listaMulti) { upg.PretCurent = upg.PretDeBaza; upg.Nivel = 0; }
            foreach (var upg in CatalogUpgradeuri.listaAuto) { upg.PretCurent = upg.PretDeBaza; upg.Nivel = 0; }
        }


        private void AdaugaCookie() 
        { totalClicks += (click * Multi); 
            manualcps += (click * Multi); 
            ActualizeazaInterfata(); }

        public void ActualizeazaInterfata()
        {
            label1.Text = "Cookies: " + Utilitare.FormateazaNumar(totalClicks);
            label3.Text = "Rebirth points: " + Utilitare.FormateazaNumar(rebirthpoints);
            RebirthPrice.Text = "Pret Rebirth: " + Utilitare.FormateazaNumar(pretrebirth) + " Cookies";
            RebirthButton.BackColor = totalClicks >= pretrebirth ? Color.Green : Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (autoCookies > 0) { totalClicks += autoCookies; ActualizeazaInterfata(); }
            label2.Text = "CPS: " + Utilitare.FormateazaNumar(autoCookies + manualcps);
            manualcps = 0;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if ((DateTime.Now - ultimuclick).TotalMilliseconds < cooldownclickms || BackgroundImage == null) return ;

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
        }

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

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = textePlutitoare.Count - 1; i >= 0; i--)
            {
                textePlutitoare[i].Y -= 2f; textePlutitoare[i].Alpha -= 10;
                if (textePlutitoare[i].Alpha <= 0) textePlutitoare.RemoveAt(i);
            }
            if (textePlutitoare.Count > 0) Invalidate();
        }

        private void Form1_Resize(object sender, EventArgs e) { Invalidate(); }

        private void DeschideInPanel(Form shopForm)
        {
            panelshop.Controls.Clear();
            shopForm.TopLevel = false; shopForm.FormBorderStyle = FormBorderStyle.None; shopForm.Dock = DockStyle.Fill;
            panelshop.Controls.Add(shopForm); shopForm.Show();
            panelshop.Visible = true; buttonCloseShop.Visible = true;
        }

        private void ClickShop_Click(object sender, EventArgs e) { if (fereastraClickShop == null || fereastraClickShop.IsDisposed) fereastraClickShop = new ClickShop(); DeschideInPanel(fereastraClickShop); }
        private void MultiShop_Click(object sender, EventArgs e) { if (fereastraMultiShop == null || fereastraMultiShop.IsDisposed) fereastraMultiShop = new MultiShop(); DeschideInPanel(fereastraMultiShop); }
        private void AutoShop_Click_1(object sender, EventArgs e) { if (fereastraAutoShop == null || fereastraAutoShop.IsDisposed) fereastraAutoShop = new AutoShop(); DeschideInPanel(fereastraAutoShop); }

        private void butonRebirthShop_Click(object sender, EventArgs e)
        {
            if (fereastraRebirth == null || fereastraRebirth.IsDisposed) fereastraRebirth = new RebirthShop();
            panelRebirth.Controls.Clear();
            fereastraRebirth.TopLevel = false; fereastraRebirth.FormBorderStyle = FormBorderStyle.None; fereastraRebirth.Dock = DockStyle.Fill;
            panelRebirth.Controls.Add(fereastraRebirth); fereastraRebirth.Show();
            panelRebirth.BringToFront(); panelRebirth.Visible = true;
        }

        private void buttonCloseShop_Click_1(object sender, EventArgs e) { panelshop.Controls.Clear(); panelshop.Visible = false; buttonCloseShop.Visible = false; }
        public void InchideRebirthShop() { panelRebirth.Controls.Clear(); panelRebirth.Visible = false; }
        private void RebirthButton_Click(object sender, EventArgs e) { CumparaRebirth(); }

        
    }
}