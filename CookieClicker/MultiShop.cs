using System;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class MultiShop : Form
    {
        public MultiShop()
        {
            InitializeComponent();
            ActualizeazaPreturi();
        }

        public void ActualizeazaPreturi()
        {


            label1.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaMulti[0].PretCurent);
            label2.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaMulti[1].PretCurent);
            label3.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaMulti[2].PretCurent);
            label4.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaMulti[3].PretCurent);
        }

        private void multi2x_Click(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaMulti[0]);
            if (succes == true)
            {
                ActualizeazaPreturi();
            }
        }

        private void multi5x_Click_1(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaMulti[1]);
            if (succes) ActualizeazaPreturi();
        }

        private void multi10x_Click_1(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaMulti[2]);
            if (succes) ActualizeazaPreturi();
        }
        private void multi25x_Click_1(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaMulti[3]);
            if (succes) ActualizeazaPreturi();
        }
    }
}