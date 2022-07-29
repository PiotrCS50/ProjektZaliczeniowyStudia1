using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Czcionka;
using MainMenu;

namespace ProjektKoncowy
{
    class Sklep
    {
        BazaBroni bazaBroni;
        List<Bron> Bron;
        Bohater bohater;
        Class1 czionka = new Class1();

        public Sklep(BazaBroni baza, Bohater b)
        {
            this.bazaBroni = baza;
            Bron = baza.DajBronie();
            this.bohater = b;
        }
        public void SklepMenu()
        {
            Console.SetCursorPosition(2, 2);
            czionka.Wypisz(0,0,"Sklep");
            string[] BronieText = new string[bazaBroni.Ilosc()];
            for(int i = 0; i < bazaBroni.Ilosc(); i++)
            {
                BronieText[i] = Bron[i].DaneBroniZKosztem();
            }
            
            GuiMenu Menu = new GuiMenu();
            Menu.WpiszDane(BronieText, 7);
            int wybor = Menu.OtworzMenu();
            if (wybor != -1) 
            {
                if (bohater.WilekoscPlecaka() < 10)
                {
                    if (bohater.Zloto >= Bron[wybor].Koszt)
                    {
                        bohater.Zloto -= Bron[wybor].Koszt;
                        bohater.WezBron(Bron[wybor]);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Za mało złota!");
                        Thread.Sleep(3000);
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Brak miejsca w plecaku!");
                    Thread.Sleep(3000);
                }
            }
            Console.Clear();

        }
    }
}
