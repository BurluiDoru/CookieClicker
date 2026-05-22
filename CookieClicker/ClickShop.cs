using System;
using System.Drawing;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class ClickShop : Form
    {
        public ClickShop()
        {
            InitializeComponent();

            StyleUpgradePanel(panel1, label1Title, "🍪 Click +1", label1, label1Nr, new Point(3, 3), Color.FromArgb(45, 110, 185));
            StyleUpgradePanel(panel2, label2Title, "🍪 Click +5", label2, label2Nr, new Point(254, 3), Color.FromArgb(50, 155, 85));
            StyleUpgradePanel(panel3, label3Title, "🍪 Click +10", label3, label3Nr, new Point(505, 3), Color.FromArgb(185, 110, 25));
            // Noul panou pentru +25 Click
            StyleUpgradePanel(panel4, label4Title, "🍪 Click +25", label4, label4Nr, new Point(756, 3), Color.FromArgb(150, 50, 150));

            ActualizeazaPreturi();
        }

        private static void StyleUpgradePanel(Panel pnl, Label titleLbl, string title, Label priceLbl, Label countLbl, Point location, Color accent)
        {
            pnl.BackColor = Color.FromArgb(30, 22, 12);
            pnl.Location = location;
            pnl.Size = new Size(245, 70);
            pnl.Cursor = Cursors.Hand;

            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            titleLbl.ForeColor = accent;
            titleLbl.BackColor = Color.Transparent;
            titleLbl.Location = new Point(8, 8);
            titleLbl.Text = title;
            titleLbl.Cursor = Cursors.Hand;
            pnl.Controls.Add(titleLbl);

            priceLbl.AutoSize = true;
            priceLbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            priceLbl.ForeColor = Color.FromArgb(220, 200, 140);
            priceLbl.BackColor = Color.Transparent;
            priceLbl.Location = new Point(8, 32);
            priceLbl.Text = "Price: ...";
            priceLbl.Cursor = Cursors.Hand;
            pnl.Controls.Add(priceLbl);

            countLbl.AutoSize = true;
            countLbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            countLbl.ForeColor = Color.FromArgb(160, 160, 160);
            countLbl.BackColor = Color.Transparent;
            countLbl.Location = new Point(165, 8);
            countLbl.Text = "Owned: 0";
            countLbl.Cursor = Cursors.Hand;
            pnl.Controls.Add(countLbl);
        }

        public void ActualizeazaPreturi()
        {
            label1.Text = "Price: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaClick[0].PretCurent);
            label1Nr.Text = "Owned: " + CatalogUpgradeuri.listaClick[0].Nivel;

            label2.Text = "Price: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaClick[1].PretCurent);
            label2Nr.Text = "Owned: " + CatalogUpgradeuri.listaClick[1].Nivel;

            label3.Text = "Price: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaClick[2].PretCurent);
            label3Nr.Text = "Owned: " + CatalogUpgradeuri.listaClick[2].Nivel;

            // Actualizare text pentru noul upgrade
            label4.Text = "Price: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaClick[3].PretCurent);
            label4Nr.Text = "Owned: " + CatalogUpgradeuri.listaClick[3].Nivel;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaClick[0])) ActualizeazaPreturi();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaClick[1])) ActualizeazaPreturi();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaClick[2])) ActualizeazaPreturi();
        }

        // Functia de click pentru noul panou
        private void panel4_Click(object sender, EventArgs e)
        {
            if (Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaClick[3])) ActualizeazaPreturi();
        }
    }
}