using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKoncowy
{
    class Ramka
    {
        int StartX, StartY, Wysokosc, Szerokosc, srodek;
        string Nazwa;
        public Ramka(int startx, int starty, int wysokosc, int szerokosc, string nazwa)
        {
            StartX = startx;
            StartY = starty;
            Wysokosc = wysokosc;
            Szerokosc = szerokosc;
            Nazwa = nazwa;
            srodek = ((szerokosc - Nazwa.Length) / 2)+startx;

        }

        public void RysujRamkeBohatera(int Hp, int HpMax, int Xp, int Zloto, string NazwaBroni, int obrazeniaBroni, int Lvl)
        {
            int proporcje = (Hp*30) / HpMax;
            ConsoleColor KolorBazowy = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(StartX, StartY);
            for(int i = 0; i <= Szerokosc; i++)
            {
                Console.Write(" ");
            }

            Console.SetCursorPosition(StartX, StartY);
            for (int i = 0; i <= Wysokosc; i++)
            {
                Console.Write(" ");
                Console.SetCursorPosition(StartX, StartY + i);
            }

            Console.SetCursorPosition(StartX, StartY + Wysokosc);
            for (int i = 0; i <= Szerokosc; i++)
            {
                Console.Write(" ");
            }

            Console.SetCursorPosition(StartX + Szerokosc, StartY);
            for (int i = 0; i <= Wysokosc; i++)
            {
                Console.Write(" ");
                Console.SetCursorPosition(StartX + Szerokosc, StartY + i);
            }
            Console.BackgroundColor = KolorBazowy;
            Console.SetCursorPosition(srodek, StartY + 2);
            Console.Write(Nazwa);
            Console.SetCursorPosition(StartX + 2, StartY + 4);
            Console.Write(NazwaBroni);
            Console.SetCursorPosition(StartX + NazwaBroni.Length + 2, StartY + 4);
            Console.Write($"( {obrazeniaBroni} )");
            Console.SetCursorPosition(StartX + 2, StartY + 6);
            Console.Write("HP: " + Hp);
            Console.SetCursorPosition(StartX + 22, StartY + 6);
            Console.Write("XP: " + Xp);
            Console.SetCursorPosition(StartX + 2, StartY + 8);
            Console.Write("LVL: " + Lvl);
            Console.SetCursorPosition(StartX + 22, StartY + 8);
            Console.Write("Złoto: " + Zloto);
            Console.SetCursorPosition(StartX + 2, StartY + 10);
            Console.Write("|");
            Console.SetCursorPosition(StartX + 3, StartY + 10);
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i < proporcje; i++)
            {
                Console.Write(" ");
                Console.SetCursorPosition(StartX + 3 + i, StartY + 10);
            }
            Console.BackgroundColor = KolorBazowy;
            Console.SetCursorPosition(StartX + 32,StartY + 10);
            Console.Write("|");
        }

        public void RysujRamkePrzeciwnika(int Hp, int HpMax, string NazwaBroni, int obrazeniaBroni, int Lvl)
        {
            double proporcje = (Hp*30) / HpMax;
            ConsoleColor KolorBazowy = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(StartX, StartY);
            for (int i = 0; i <= Szerokosc; i++)
            {
                Console.Write(" ");
            }

            Console.SetCursorPosition(StartX, StartY);
            for (int i = 0; i <= Wysokosc; i++)
            {
                Console.Write(" ");
                Console.SetCursorPosition(StartX, StartY + i);
            }

            Console.SetCursorPosition(StartX, StartY + Wysokosc);
            for (int i = 0; i <= Szerokosc; i++)
            {
                Console.Write(" ");
            }

            Console.SetCursorPosition(StartX + Szerokosc, StartY);
            for (int i = 0; i <= Wysokosc; i++)
            {
                Console.Write(" ");
                Console.SetCursorPosition(StartX + Szerokosc, StartY + i);
            }
            Console.BackgroundColor = KolorBazowy;
            Console.SetCursorPosition(srodek, StartY + 2);
            Console.Write(Nazwa);
            Console.SetCursorPosition(StartX + 2, StartY + 4);
            Console.Write(NazwaBroni);
            Console.SetCursorPosition(StartX + NazwaBroni.Length + 2, StartY + 4);
            Console.Write($"( {obrazeniaBroni} )");
            Console.SetCursorPosition(StartX + 2, StartY + 6);
            Console.Write("HP: " + Hp);
            Console.SetCursorPosition(StartX + 22, StartY + 6);
            Console.Write("LVL: " + Lvl);
            Console.SetCursorPosition(StartX + 2, StartY + 8);
            Console.Write("|");
            Console.SetCursorPosition(StartX + 3, StartY + 8);
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i < proporcje; i++)
            {
                Console.Write(" ");
                Console.SetCursorPosition(StartX + 3 + i, StartY + 8);
            }
            Console.BackgroundColor = KolorBazowy;
            Console.SetCursorPosition(StartX + 33, StartY + 8);
            Console.Write("|");
        }
    }
}
