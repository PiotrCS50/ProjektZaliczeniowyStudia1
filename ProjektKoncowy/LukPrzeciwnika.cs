using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKoncowy
{
    class LukPrzeciwnika : Bron
    {
        public LukPrzeciwnika(string nazwa, int obrazenia, int koszt) : base(nazwa, obrazenia, koszt)
        {

        }
        public LukPrzeciwnika(string nazwa, int obrazenia) : base(nazwa, obrazenia)
        {

        }

        public override void Rysuj(int x, int y)
        {
            Console.SetCursorPosition(69, y);
            Console.Write("  /|");
            Console.SetCursorPosition(69, y + 1);
            Console.Write(" / |");
            Console.SetCursorPosition(69, y + 2);
            Console.Write("|  |");
            Console.SetCursorPosition(69, y + 3);
            Console.Write(" \\ |");
            Console.SetCursorPosition(69, y + 4);
            Console.Write("  \\|");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("<---<-");
        }
    }
}
