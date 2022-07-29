using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainMenu;

namespace ProjektKoncowy
{
    class MenuGry
    {
        Bohater bohater;
        Przygoda przygoda;
        BazaBroni bazaBroni;
        BazaPrzeciwnikow BazaPrzeciwnikow;
        WczytywanieDanych dane;
        public MenuGry(Bohater bohater, Przygoda p, BazaBroni baza, BazaPrzeciwnikow bp, WczytywanieDanych dane)
        {
            this.bohater = bohater;
            this.przygoda = p;
            this.bazaBroni = baza;
            this.BazaPrzeciwnikow = bp;
            this.dane = dane;
        }
        public int Menu()
        {
            Console.Clear();
            bohater.RysujDane();
            GuiMenu MenuG = new GuiMenu();
            MenuG.WpiszDane(new string[] {
                "Idź na przygodę",
                "Wybór broni",
                "Sklep"
            }, 23);
            int wybor = MenuG.OtworzMenu();
            if (wybor == -1) return 1;
            switch (wybor)
            {
                case 0:
                    if (bohater.WilekoscPlecaka() == 10)
                    {
                        Console.SetCursorPosition(bohater.X / 2, bohater.Y);
                        Console.WriteLine("Brak miejsca w plecaku. \nZdobyty przedmiot nie zostanie dodany do twojego plecaka!\nWciśnij Enter by kontynuować lub Esp by anulować przygodę");
                        ConsoleKeyInfo key = Console.ReadKey();
                        if (key.Key == ConsoleKey.Enter)
                        {
                            przygoda.IdzNaPrzygode();
                            if (bohater.LvlPodniesiony)
                                Aktualizuj();
                            Menu();
                        }
                        else
                        {
                            Menu();
                        }
                    }
                    przygoda.IdzNaPrzygode();
                    if (bohater.LvlPodniesiony)
                        Aktualizuj();
                    Menu();
                    break;

                case 1:
                    MenuBroni Bronie = new MenuBroni(bohater);
                    Bronie.Menu();
                    Menu();
                    break;

                case 2:
                    Sklep sklep = new Sklep(bazaBroni, bohater);
                    sklep.SklepMenu();
                    Menu();
                    break;
            }
            return 0;
        }

        public void Aktualizuj()
        {
            dane.WczytajBron(bohater, bazaBroni);
            dane.WczytajPrzeciwnikow(bohater, BazaPrzeciwnikow);
        }

    }
}
