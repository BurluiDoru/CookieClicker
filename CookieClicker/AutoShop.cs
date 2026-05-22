using System;
using System.Drawing; 
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class AutoShop : Form
    {
        public AutoShop()
        {
            InitializeComponent();
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
        ?.SetValue(flowLayoutPanel1, true, null);

            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.SetValue(clipPanel, true, null);
            StyleUpgradePanel(AutoUpgrade1, label4, "⚙ Auto CPS +1", PretAutoUpgrade1, AutoUpgrade1Nr, new Point(3, 3), 7, Color.FromArgb(45, 110, 185));
            StyleUpgradePanel(panel2, label10, "⚙ Auto CPS +5", PretAutoUpgrade2, AutoUpgrade2Nr, new Point(254, 3), 8, Color.FromArgb(50, 155, 85));
            StyleUpgradePanel(AutoUpgrade3, label7, "⚙ Auto CPS +10", PretAutoUpgrade3, AutoUpgrade3Nr, new Point(505, 3), 8, Color.FromArgb(185, 110, 25));
            StyleUpgradePanel(AutoUpgrade4, label5, "⚙ Auto CPS +20", PretAutoUpgrade4, AutoUpgrade4Nr, new Point(756, 3), 10, Color.FromArgb(150, 50, 150));

            ActualizeazaPreturi();
        }

        private static void StyleUpgradePanel(Panel pnl, Label titleLbl, string title, Label priceLbl, Label countLbl, Point location, int tabIndex, Color accent)
        {
            pnl.BackColor = Color.FromArgb(30, 22, 12);
            pnl.Location = location;
            pnl.Size = new Size(245, 70);
            pnl.TabIndex = tabIndex;
            pnl.Cursor = Cursors.Hand;

            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            titleLbl.ForeColor = accent;
            titleLbl.BackColor = Color.Transparent;
            titleLbl.Location = new Point(8, 8);
            titleLbl.Text = title;
            pnl.Controls.Add(titleLbl);

            priceLbl.AutoSize = true;
            priceLbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            priceLbl.ForeColor = Color.FromArgb(220, 200, 140);
            priceLbl.BackColor = Color.Transparent;
            priceLbl.Location = new Point(8, 32);
            priceLbl.Text = "Price: ...";
            pnl.Controls.Add(priceLbl);

            countLbl.AutoSize = true;
            countLbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            countLbl.ForeColor = Color.FromArgb(160, 160, 160);
            countLbl.BackColor = Color.Transparent;
            countLbl.Location = new Point(160, 8);
            countLbl.Text = "Owned: 0";
            pnl.Controls.Add(countLbl);
        }

        public void ActualizeazaPreturi()
        {
            PretAutoUpgrade1.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaAuto[0].PretCurent);
            AutoUpgrade1Nr.Text = "Owned: " + CatalogUpgradeuri.listaAuto[0].Nivel;

            PretAutoUpgrade2.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaAuto[1].PretCurent);
            AutoUpgrade2Nr.Text = "Owned: " + CatalogUpgradeuri.listaAuto[1].Nivel;

            PretAutoUpgrade3.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaAuto[2].PretCurent);
            AutoUpgrade3Nr.Text = "Owned: " + CatalogUpgradeuri.listaAuto[2].Nivel;

            PretAutoUpgrade4.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaAuto[3].PretCurent);
            AutoUpgrade4Nr.Text = "Owned: " + CatalogUpgradeuri.listaAuto[3].Nivel;
        }

        private void AutoUpgrade1_Click(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaAuto[0]);
            if (succes) ActualizeazaPreturi();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaAuto[0]);
            if (succes) ActualizeazaPreturi();
        }

        private void PretAutoUpgrade1_Click(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaAuto[0]);
            if (succes) ActualizeazaPreturi();
        }

        private void AutoUpgrade1Nr_Click(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaAuto[0]);
            if (succes) ActualizeazaPreturi();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaAuto[1]);
            if (succes) ActualizeazaPreturi();
        }

        private void AutoUpgrade3_Click(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaAuto[2]);
            if (succes) ActualizeazaPreturi();
        }

        private void PretAutoUpgrade2_Click(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaAuto[1]);
            if (succes) ActualizeazaPreturi();
        }

        private void AutoUpgrade2Nr_Click(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaAuto[1]);
            if (succes) ActualizeazaPreturi();
        }

        private void PretAutoUpgrade3_Click(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaAuto[2]);
            if (succes) ActualizeazaPreturi();
        }

        private void AutoUpgrade3Nr_Click(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaAuto[2]);
            if (succes) ActualizeazaPreturi();
        }

        private void AutoUpgrade4_Click_1(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaAuto[3]);
            if (succes) ActualizeazaPreturi();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaAuto[3]);
            if (succes) ActualizeazaPreturi();
        }

        private void PretAutoUpgrade4_Click_1(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaAuto[3]);
            if (succes) ActualizeazaPreturi();
        }

        private void AutoUpgrade4Nr_Click_1(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaAuto[3]);
            if (succes) ActualizeazaPreturi();
        }
    }
}