using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
    public static class Utilitare
    {
        public class TextPlutitor
        {
            public float X;
            public float Y;
            public string Text;
            public int Alpha = 255;
        }
        public static string FormateazaNumar(double numar)
        {
            if (numar >= 1e33) return (numar / 1e33).ToString("0.##") + " Dc";
            if (numar >= 1e30) return (numar / 1e30).ToString("0.##") + " No";
            if (numar >= 1e27) return (numar / 1e27).ToString("0.##") + " Oc";
            if (numar >= 1e24) return (numar / 1e24).ToString("0.##") + " Sp";
            if (numar >= 1e21) return (numar / 1e21).ToString("0.##") + " Sx";
            if (numar >= 1e18) return (numar / 1e18).ToString("0.##") + " Qi";
            if (numar >= 1e15) return (numar / 1e15).ToString("0.##") + " Qa";
            if (numar >= 1e12) return (numar / 1e12).ToString("0.##") + " T";
            if (numar >= 1e9) return (numar / 1e9).ToString("0.##") + " B";
            if (numar >= 1e6) return (numar / 1e6).ToString("0.##") + " M";
            if (numar >= 1e3) return (numar / 1e3).ToString("0.##") + " K";
            return Math.Floor(numar).ToString();
        }
        public static void Save(Form1 joc)
        {
            Properties.Settings.Default.SavedClicks = joc.totalClicks;
            Properties.Settings.Default.SavedMulti = joc.Multi; 
            Properties.Settings.Default.SavedClickPower = joc.click;
            Properties.Settings.Default.SavedAutoCookies = joc.autoCookies;

            Properties.Settings.Default.SavedRebirths = joc.rebirths;
            Properties.Settings.Default.SavedRebirthPoints = joc.rebirthpoints;
            Properties.Settings.Default.SavedPretRebirth = joc.pretrebirth;

            Properties.Settings.Default.SalvarePreturiClick = string.Join(";", CatalogUpgradeuri.listaClick.Select(u => u.PretCurent));
            Properties.Settings.Default.SalvarePreturiMulti = string.Join(";", CatalogUpgradeuri.listaMulti.Select(u => u.PretCurent));
            Properties.Settings.Default.SalvarePreturiAuto = string.Join(";", CatalogUpgradeuri.listaAuto.Select(u => u.PretCurent));
            Properties.Settings.Default.SalvarePreturiClick = string.Join(";", CatalogUpgradeuri.listaClick.Select(u => u.PretCurent));
            Properties.Settings.Default.SalvarePreturiMulti = string.Join(";", CatalogUpgradeuri.listaMulti.Select(u => u.PretCurent));
            Properties.Settings.Default.SalvarePreturiAuto = string.Join(";", CatalogUpgradeuri.listaAuto.Select(u => u.PretCurent));

            Properties.Settings.Default.SalvareNiveluriClick = string.Join(";", CatalogUpgradeuri.listaClick.Select(u => u.Nivel));
            Properties.Settings.Default.SalvareNiveluriMulti = string.Join(";", CatalogUpgradeuri.listaMulti.Select(u => u.Nivel));
            Properties.Settings.Default.SalvareNiveluriAuto = string.Join(";", CatalogUpgradeuri.listaAuto.Select(u => u.Nivel));


            Properties.Settings.Default.Save();
        }
        public static void IncarcaNiveluriDinSalvare(System.Collections.Generic.List<Upgrade> lista, string salvare)
        {
            if (string.IsNullOrEmpty(salvare)) return;

            string[] parti = salvare.Split(';');
            for (int i = 0; i < parti.Length && i < lista.Count; i++)
            {
                if (int.TryParse(parti[i], out int nivel))
                {
                    lista[i].Nivel = nivel;
                }
            }
        }
        public static void Load(Form1 joc)
        {
            joc.totalClicks = Properties.Settings.Default.SavedClicks;
            joc.Multi = Properties.Settings.Default.SavedMulti;
            joc.click = Properties.Settings.Default.SavedClickPower;
            joc.autoCookies = Properties.Settings.Default.SavedAutoCookies;

            IncarcaNiveluriDinSalvare(CatalogUpgradeuri.listaClick, Properties.Settings.Default.SalvareNiveluriClick);
            IncarcaNiveluriDinSalvare(CatalogUpgradeuri.listaMulti, Properties.Settings.Default.SalvareNiveluriMulti);
            IncarcaNiveluriDinSalvare(CatalogUpgradeuri.listaAuto, Properties.Settings.Default.SalvareNiveluriAuto);
            joc.rebirths = (int)Properties.Settings.Default.SavedRebirths;
            joc.rebirthpoints = (int)Properties.Settings.Default.SavedRebirthPoints;
            joc.pretrebirth = Properties.Settings.Default.SavedPretRebirth;

            if (joc.pretrebirth < 1000) joc.pretrebirth = 1000;

            IncarcaPreturiDinSalvare(CatalogUpgradeuri.listaClick, Properties.Settings.Default.SalvarePreturiClick);
            IncarcaPreturiDinSalvare(CatalogUpgradeuri.listaMulti, Properties.Settings.Default.SalvarePreturiMulti);
            IncarcaPreturiDinSalvare(CatalogUpgradeuri.listaAuto, Properties.Settings.Default.SalvarePreturiAuto);
        }

        public static void IncarcaPreturiDinSalvare(List<Upgrade> lista, string salvare)
        {
            if (!string.IsNullOrEmpty(salvare))
            {
                string[] preturi = salvare.Split(';');
                for (int i = 0; i < preturi.Length && i < lista.Count; i++)
                {
                    lista[i].PretCurent = double.Parse(preturi[i]);
                }
            }
        }
    }
}
