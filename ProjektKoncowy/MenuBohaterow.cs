using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Czcionka;
using MainMenu;

namespace ProjektKoncowy
{
    class MenuBohaterow
    {
        BazaBohaterow bazaBohaterow;
        Class1 czcionka = new Class1();
        public MenuBohaterow(BazaBohaterow baza)
        {
            this.bazaBohaterow = baza;
        }
        public int Menu()
        {
            GuiMenu menuBohaterow = new GuiMenu();
            int wybor = 0;
            int ilosc = 0;
            if (bazaBohaterow.Ilosc() > 0)
            {
                czcionka.Wypisz(0,0,"Bohaterowie");
                if (bazaBohaterow.Ilosc() < 3)
                    ilosc = bazaBohaterow.Ilosc() + 1;
                else
                    ilosc = bazaBohaterow.Ilosc();
                string[] elementy = new string[ilosc];
                for (int i = 0; i < bazaBohaterow.Ilosc(); i++)
                {
                    elementy[i] = bazaBohaterow.DaneBohatera(i);
                }
                if(bazaBohaterow.Ilosc() < 3)
                    elementy[bazaBohaterow.Ilosc()] = "Dodaj Bohatera"; 
                menuBohaterow.WpiszDane(elementy,7);
                wybor = menuBohaterow.OtworzMenu();
                if (wybor == -1) return -1;
                else if (wybor == bazaBohaterow.Ilosc())
                {
                    bazaBohaterow.DodajBohatera();
                    if (Menu() == -1) return -1;
                }
                else bazaBohaterow.AktualnyBohater(wybor);
                return 0;

            }
            else
            {
                Console.WriteLine("Brak Bohaterow!");
                string[] el = {"Dodaj bohatera"};
                menuBohaterow.WpiszDane(el,2);
                wybor = menuBohaterow.OtworzMenu();
                if (wybor == -1) return -1;
                else
                {
                    bazaBohaterow.DodajBohatera();
                    if(Menu() == -1) return -1;
                    return 0;
                }

            }

        }

    }
}
