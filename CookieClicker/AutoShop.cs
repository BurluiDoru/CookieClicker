using System;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class AutoShop : Form
    {
        public AutoShop()
        {
            InitializeComponent();
            ActualizeazaPreturi();
        }

        public void ActualizeazaPreturi()
        {

            PretAutoUpgrade1.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaAuto[0].PretCurent);
            PretAutoUpgrade2.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaAuto[1].PretCurent);
            PretAutoUpgrade3.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaAuto[2].PretCurent);
            PretAutoUpgrade4.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaAuto[3].PretCurent);
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
