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
        private void cps1_Click(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgradeInteligent(CatalogUpgradeuri.listaAuto[0]);
            if (succes) ActualizeazaPreturi();
        }
        private void cps2_Click_1(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgradeInteligent(CatalogUpgradeuri.listaAuto[1]);
            if (succes) ActualizeazaPreturi();
        }
        private void cps3_Click_1(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgradeInteligent(CatalogUpgradeuri.listaAuto[2]);
            if (succes) ActualizeazaPreturi();
        }
    }
}
