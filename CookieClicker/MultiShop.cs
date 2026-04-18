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

        // 2. Functia care schimba textele de pe ecran
        public void ActualizeazaPreturi()
        {
            // ATENTIE: Inlocuieste "labelPret2x" cu numele real al textului/butonului tau din Design!
            // Extragem pretul direct din lista inteligenta a Form1 si il formatam frumos:

            label1.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaMulti[0].PretCurent);
            label2.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaMulti[1].PretCurent);
            label3.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaMulti[2].PretCurent);
            label4.Text = "Pret: " + Utilitare.FormateazaNumar(CatalogUpgradeuri.listaMulti[3].PretCurent);
        }

        // 3. BUTOANELE DE CUMPARARE

        // Butonul pentru primul upgrade (Multi 2x) -> Indexul 0
        private void multi2x_Click(object sender, EventArgs e)
        {
            // Ii spunem functiei inteligente din Form1 sa ne cumpere upgrade-ul de pe pozitia 0
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaMulti[0]);

            // Daca a reusit cumpararea, actualizam textul de pe ecran ca sa arate noul pret (mai mare)
            if (succes == true)
            {
                ActualizeazaPreturi();
            }
        }

        // Butonul pentru al doilea upgrade (Multi 5x) -> Indexul 1
        private void multi5x_Click_1(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaMulti[1]);
            if (succes) ActualizeazaPreturi();
        }

        // Butonul pentru al treilea upgrade (Multi 10x) -> Indexul 2
        private void multi10x_Click_1(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaMulti[2]);
            if (succes) ActualizeazaPreturi();
        }

        // Butonul pentru al patrulea upgrade (Multi 25x) -> Indexul 3
        private void multi25x_Click_1(object sender, EventArgs e)
        {
            bool succes = Form1.Instanta.CumparaUpgrade(CatalogUpgradeuri.listaMulti[3]);
            if (succes) ActualizeazaPreturi();
        }
    }
}