using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKoncowy
{
    class Przeciwnik : Osoba
    {
        Ramka ramka;
        string NazwaBroni;
        public int startX { get; set; }
        public Przeciwnik(string nazwa, int hpMax, int lvl, string nazwaBroni, int obrazenia, string typ) : base(nazwa, hpMax, lvl)
        {
            UstawBron(typ, nazwa, obrazenia);
            ramka = new Ramka(startX = 79, 2, 10, 40, Nazwa);
            NazwaBroni = nazwaBroni;
        }

        private void UstawBron(string typ, string nazwa, int obrazenia)
        {
            if (typ == "miecz")
                UzywanaBron = new Miecz(NazwaBroni, obrazenia);
            else if (typ == "topor")
                UzywanaBron = new Topor(NazwaBroni, obrazenia);
            else if (typ == "luk")
                UzywanaBron = new LukPrzeciwnika(NazwaBroni, obrazenia);
            else
                UzywanaBron = new Miecz(NazwaBroni, obrazenia);
        }

        override public void RysujDane()
        {
            ramka.RysujRamkePrzeciwnika(Hp, MaxHp, NazwaBroni, UzywanaBron.Obrazenia, Lvl);
        }
    }
}
