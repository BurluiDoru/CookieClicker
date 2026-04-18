using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
    public enum TipUpgrade
    {
        Click,
        Multi,
        Auto
    }
    public class Upgrade
    {
        public string Nume;
        public double PretDeBaza;
        public double PretCurent;
        public double Bonus;
        public int Nivel;
        public TipUpgrade Tip;

        //constructor pentru upgrade-uri
        public Upgrade(string nume ,double pretBaza, double bonus,TipUpgrade tip)
        {
            this.Nume = nume;
            this.PretDeBaza = pretBaza;
            this.PretCurent = pretBaza;
            this.Bonus = bonus;
            this.Nivel = 0;
            this.Tip = tip;
        }
    }
    public static class CatalogUpgradeuri
    {
        public static List<Upgrade> listaClick = new List<Upgrade>();
        public static List<Upgrade> listaMulti = new List<Upgrade>();
        public static List<Upgrade> listaAuto = new List<Upgrade>();
        
          public static void ConstruiesteCatalogul()
        {
            // Upgrade-uri pentru Click
            listaClick.Add(new Upgrade("Click +1", 10, 1, TipUpgrade.Click));
            listaClick.Add(new Upgrade("Click +5", 100, 5, TipUpgrade.Click));
            listaClick.Add(new Upgrade("Click +10", 1000, 10, TipUpgrade.Click));
            // Upgrade-uri pentru Multi
            listaMulti.Add(new Upgrade("Multi 2x", 50, 1, TipUpgrade.Multi));
            listaMulti.Add(new Upgrade("Multi 5x", 500, 4, TipUpgrade.Multi));
            listaMulti.Add(new Upgrade("Multi 10x", 5000, 9, TipUpgrade.Multi));
            listaMulti.Add(new Upgrade("Multi 25x", 25000, 24, TipUpgrade.Multi));
            // Upgrade-uri pentru Auto
            listaAuto.Add(new Upgrade("Auto +1 CPS", 200, 1, TipUpgrade.Auto));
            listaAuto.Add(new Upgrade("Auto +5 CPS", 2000, 5, TipUpgrade.Auto));
            listaAuto.Add(new Upgrade("Auto +10 CPS", 20000, 10, TipUpgrade.Auto));
            listaAuto.Add(new Upgrade("Auto +20 CPS", 40000, 20, TipUpgrade.Auto));

        }

    }
}
