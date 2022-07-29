using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKoncowy
{
    class Bohater : Osoba
    {
        private int xp = 0;
        public int Zloto { get; set; }
        private List<Bron> ListaBroni = new List<Bron>();
        private Ramka ramka;
        public bool LvlPodniesiony = false;
        
        public int X { get; set; }
        public int Y { get; set; }
        public int Xp {
            get
            {
                return xp;
            }
            set
            {
                xp += value;
                LvlPodniesiony = false;
                if(xp >= 100 * Lvl)
                {
                    xp = xp - 100 * Lvl;
                    lvl++;
                    MAXhp = 100 * Lvl;
                    Hp = MaxHp;
                    LvlPodniesiony = true;
                }
            }
        }

        public Bohater() : base()
        {
            Console.Write("Podaj nazwę Bohatera: ");
            nazwa = Console.ReadLine();
            Xp = 0;
            Zloto = 20;
            UzywanaBron = new Piesc("Pięść", 3);
            ListaBroni.Add(UzywanaBron);
            ramka = new Ramka(X = 2, Y = 2, Y += 12, X += 40, Nazwa);
        }

        public Bohater(string nazwa, int hpMax, int lvl) : base(nazwa, hpMax, lvl)
        {
            ramka = new Ramka(2, 2, 12, 40, Nazwa);
            UzywanaBron = new Piesc("Pięść", 3);
            ListaBroni.Add(UzywanaBron);
            Xp = 0;
            Zloto = 20;
        }

        override public void RysujDane()
        {
            ramka.RysujRamkeBohatera(Hp, MaxHp, Xp, Zloto, UzywanaBron.Nazwa, UzywanaBron.Obrazenia, Lvl);
        }

        public void WezBron(Bron bron)
        {
            if(ListaBroni.Count < 10)
            {
                ListaBroni.Add(bron);
            }
        }

        public void PorzucBron(int id)
        {
            if(id > 0 && id < 10)
                ListaBroni.RemoveAt(id);
        }

        public int WilekoscPlecaka()
        {
            return ListaBroni.Count();
        }

        public List<Bron> DajBronie()
        {
            return ListaBroni;
        }

    }
}
