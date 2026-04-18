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

        // 2. Functia care schimba textele de pe ecran
        public void ActualizeazaPreturi()
        {
            // ATENTIE: Inlocuieste "labelPret2x" cu numele real al textului/butonului tau din Design!
            // Extragem pretul direct din lista inteligenta a Form1 si il formatam frumos:

            label1.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaClick[0].PretCurent);
            label2.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaClick[1].PretCurent);
            label3.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaClick[2].PretCurent);
        }

        // 3. BUTOANELE DE CUMPARARE
        private void button1_Click_1(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaClick[0]);
            if (succes) ActualizeazaPreturi();
        }

        // Butonul 2: +5 Cookies
        private void button2_Click_1(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaClick[1]);
            if (succes) ActualizeazaPreturi();
        }

        // Butonul 3: +10 Cookies
        private void button3_Click_1(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaClick[2]);
            if (succes) ActualizeazaPreturi();
        }
    }
}