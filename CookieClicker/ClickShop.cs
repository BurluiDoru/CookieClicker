using System;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class ClickShop : Form
    {
        public ClickShop()
        {
            InitializeComponent();
            ActualizeazaPreturi();
        }

        public void ActualizeazaPreturi()
        {

            label1.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaClick[0].PretCurent);
            label2.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaClick[1].PretCurent);
            label3.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaClick[2].PretCurent);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaClick[0]);
            if (succes) ActualizeazaPreturi();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaClick[1]);
            if (succes) ActualizeazaPreturi();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaClick[2]);
            if (succes) ActualizeazaPreturi();
        }
    }
}