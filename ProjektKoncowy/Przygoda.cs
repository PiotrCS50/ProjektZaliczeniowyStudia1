using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjektKoncowy
{
    class Przygoda
    {
        Bohater bohater;
        readonly BazaPrzeciwnikow BP;
        Przeciwnik przeciwnik;
        readonly BazaBroni BB;
        int zloto, xp;
        readonly Random rand = new Random();
        int srodek = 62;
        int czas;
        ConsoleColor KolorBazowyB = Console.BackgroundColor;
        ConsoleColor KolorBazowyF = Console.ForegroundColor;

        public Przygoda(Osoba bohater, BazaPrzeciwnikow przeciwnicy, BazaBroni bazaBroni)
        {
            this.bohater = (Bohater)bohater;
            this.BP = przeciwnicy;
            this.BB = bazaBroni;
        }
        public void IdzNaPrzygode()
        {
            int walka = rand.Next(0, 4);
            int losPrzeciwnik = rand.Next(0, BP.DajIlosc());
            przeciwnik = BP.DajPrzeciwnika(losPrzeciwnik);
            if (walka == 0 || bohater.Xp == 0)
            {
                TrwaniePrzygody(out czas);
                ZakonczeniePrzygody("Zakończyłeś przygodę!", 2, 0);
            }
            else
            {
                TrwaniePrzygody(out czas);
                Walka();
            }
        }
        private void Walka()
        {

            int obrB;
            int obrP;
            do
            {
                Rysuj(0);
                obrB = rand.Next((bohater.UzywanaBron.Obrazenia) - (5 * bohater.Lvl), (bohater.UzywanaBron.Obrazenia) + (5 * bohater.Lvl));
                if (obrB <= 0)
                    obrB = 1;
                AnimacjaBohatera(obrB);
                przeciwnik.Hp -= obrB;
                if (przeciwnik.Hp <= 0) break;
                Rysuj(0);
                obrP = rand.Next((przeciwnik.UzywanaBron.Obrazenia) - (5 * przeciwnik.Lvl), (przeciwnik.UzywanaBron.Obrazenia) + (5 * przeciwnik.Lvl));
                if (obrP <= 0)
                    obrP = 1;
                AnimacjaPrzeciwnika(obrP);
                bohater.Hp -= obrP;
                Rysuj(0);
            } while (bohater.Hp > 0 && przeciwnik.Hp > 0);
            if(bohater.Hp > 0)
            {
                ZakonczeniePrzygody("Gratulacje wygrałeś!!!", 0, 0);
            }
            else
            {
                ZakonczeniePrzygody("PRZEGRAŁEŚ!!!", 0, 1);
            }
        }
        private void AnimacjaBohatera(int obrazenia)
        {
            for(int i = 0; i < przeciwnik.startX - bohater.X -5; i++)
            {
                Rysuj(1);
                bohater.UzywanaBron.Rysuj(bohater.X+4+i,3);
                Thread.Sleep(1);
            }
            Rysuj(1);
            Console.SetCursorPosition(srodek, 9);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" -"+obrazenia+" ");
            Console.ForegroundColor = KolorBazowyF;
            Console.BackgroundColor = KolorBazowyB;
            Thread.Sleep(600);
            Console.Clear();
        }
        private void AnimacjaPrzeciwnika(int obrazenia)
        {
            for (int i = 0; i < przeciwnik.startX - bohater.X - 6; i++)
            {
                Rysuj(1);
                przeciwnik.UzywanaBron.Rysuj(przeciwnik.startX - 3 - i, 3);
                Thread.Sleep(1);
            }
            Rysuj(1);
            Console.SetCursorPosition(srodek, 9);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" -" + obrazenia+" ");
            Console.ForegroundColor = KolorBazowyF;
            Console.BackgroundColor = KolorBazowyB;
            Thread.Sleep(600);
            Console.Clear();
        }

        private void Rysuj(int opcja)
        {
            if(opcja == 0)
            {
                Console.Clear();
                bohater.RysujDane();
                przeciwnik.RysujDane();
                Thread.Sleep(100);
            }
            else if(opcja == 1)
            {
                Console.Clear();
                bohater.RysujDane();
                przeciwnik.RysujDane();
            }
            else if(opcja == 2)
            {
                Console.Clear();
                bohater.RysujDane();
            }
        }

        private void ZakonczeniePrzygody(string text, int opcja, int zakonczenie)
        {
            if (zakonczenie == 0)
            {
                Bron wygrana = null;
                int losujBron;
                zloto = rand.Next(10 * bohater.Lvl, 20 * bohater.Lvl);
                xp = rand.Next(bohater.Lvl * czas, bohater.Lvl * czas * 4);
                int czyBron = rand.Next(0, 2);
                int ilosc = BB.Ilosc();
                losujBron = rand.Next(0, ilosc);
                if (czyBron > 0)
                {
                    wygrana = BB.DajBron(losujBron);
                    bohater.WezBron(wygrana);
                }
                bohater.Xp += xp;
                bohater.Zloto += zloto;
                Rysuj(opcja);

                Console.SetCursorPosition(48, 5);
                Console.WriteLine(text);
                Console.SetCursorPosition(48, 6);
                Console.WriteLine("Zdobycze: ");
                Console.SetCursorPosition(48, 7);
                Console.WriteLine($"Złoto: {zloto}");
                Console.SetCursorPosition(48, 8);
                Console.WriteLine($"XP: {xp}");
                if (czyBron > 0)
                {
                    Console.SetCursorPosition(48, 9);
                    Console.WriteLine("Broń:");
                    Console.SetCursorPosition(53, 10);
                    Console.WriteLine($"Nazwa: {wygrana.Nazwa}");
                    Console.SetCursorPosition(53, 11);
                    Console.WriteLine($"Obrażenia: {wygrana.Obrazenia}");
                }
            }
            else {
                Console.SetCursorPosition(48, 5);
                Console.WriteLine(text);
            }
            bohater.Hp = bohater.MaxHp;
            przeciwnik.Hp = przeciwnik.MaxHp;
            Console.SetCursorPosition(48, 13);
            Console.WriteLine("Wciśnij ENTER by kontynuować...");
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Enter);
            Console.Clear();
        }

        private void TrwaniePrzygody(out int czas)
        {
            int pozY = 15;
            czas = rand.Next(3, 10);
            int odswiezanie = (czas * 1000) / 80;
            int czasTrwania = czas * 1000;
            Console.SetCursorPosition(2, pozY);
            Console.Write("|");
            Console.SetCursorPosition(2, pozY+1);
            Console.Write("|");
            Console.SetCursorPosition(83, pozY);
            Console.Write("|");
            Console.SetCursorPosition(83, pozY + 1);
            Console.Write("|");
            ConsoleColor KolorBazowy = Console.BackgroundColor;
            ConsoleColor KolorBazowyF = Console.ForegroundColor;

            Console.BackgroundColor = ConsoleColor.Gray;
            int i = 0;
            do
            {
                Console.SetCursorPosition(3 + i, pozY);
                Console.Write(" ");
                Console.SetCursorPosition(3 + i, pozY + 1);
                Console.Write(" ");
                Console.SetCursorPosition(42, pozY);
                Console.ForegroundColor = ConsoleColor.Red;
                if (czasTrwania / 1000 < 10)
                {
                    Console.Write("0"+czasTrwania/1000);
                }
                else
                    Console.Write(czasTrwania/1000);
                Console.ForegroundColor = KolorBazowyF;
                Thread.Sleep(odswiezanie);
                czasTrwania -= odswiezanie;
                i++;
            } while (czasTrwania > 1);
            Console.BackgroundColor = KolorBazowy;
            Console.Clear();
        }
    }
}
