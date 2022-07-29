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
    class MenuBroni
    {
        List<Bron> Bron;
        Bohater bohater;
        Class1 czcionka = new Class1();
        public MenuBroni(Bohater b)
        {
            this.bohater = b;
            Bron = b.DajBronie();
        }
        public void Menu()
        {
            GuiMenu MenuB = new GuiMenu();
            GuiMenu Decyzja = new GuiMenu();
            czcionka.Wypisz(0,0,"Plecak");
            string[] BronText = new string[Bron.Count()];
            for(int i = 0; i < Bron.Count(); i++)
            {
                BronText[i] = Bron[i].DaneBronibezKosztu();
            }
            MenuB.WpiszDane(BronText,7);
            Decyzja.WpiszDane(new string[] {
                "Użyj",
                "Wyrzuć"
            }, 4);
            int wybor = MenuB.OtworzMenu();
            if (wybor != -1)
            {
                Console.SetCursorPosition(2, 2);
                Console.WriteLine(Bron.ElementAt(wybor).Nazwa + ": ");
                if(Decyzja.OtworzMenu() == 1)
                {
                    
                    if(bohater.WilekoscPlecaka() == 1 || wybor == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Nie można usunąć pięści");
                        Thread.Sleep(3000);
                    }
                    bohater.PorzucBron(wybor);
                }
                else                    
                    bohater.UzywanaBron = Bron.ElementAt(wybor);
            }

        }
    }
}
