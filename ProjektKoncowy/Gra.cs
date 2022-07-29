using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Czcionka;

namespace ProjektKoncowy
{
    class Gra
    {
        int wybor = 0;
        Bohater aktualny;
        public int Graj()
        {
            Console.CursorVisible = false;
            BazaBohaterow Bohaterowie = new BazaBohaterow();
            BazaPrzeciwnikow Przeciwnicy = new BazaPrzeciwnikow();
            BazaBroni Bron = new BazaBroni();
            WczytywanieDanych Dane = new WczytywanieDanych();
            Class1 czcionka = new Class1();
            czcionka.Wypisz(15,5,"Adventure");
            czcionka.Wypisz(32,12,"GAME");
            Thread.Sleep(5000);
            Console.Clear();
            while (wybor == 0)
            {
                MenuBohaterow menuBohatera = new MenuBohaterow(Bohaterowie);
                if (menuBohatera.Menu() == -1)
                {
                    return -1;
                }
                aktualny = Bohaterowie.Aktualny;
                Przygoda przygoda = new Przygoda(aktualny, Przeciwnicy, Bron);  
                Dane.WczytajBron(aktualny, Bron);
                Dane.WczytajPrzeciwnikow(aktualny, Przeciwnicy);
                MenuGry menuGry = new MenuGry(aktualny, przygoda, Bron, Przeciwnicy, Dane);
                menuGry.Menu();
            }
            return 0;
        }

    }
}
