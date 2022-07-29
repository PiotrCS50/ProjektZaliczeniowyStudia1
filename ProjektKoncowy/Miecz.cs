using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKoncowy
{
    class Miecz : Bron
    {
        public Miecz(string nazwa, int obrazenia, int koszt) : base(nazwa, obrazenia, koszt)
        {

        }
        public Miecz(string nazwa, int obrazenia) : base(nazwa, obrazenia)
        {

        }

        public override void Rysuj(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("|");
            Console.SetCursorPosition(x, y+1);
            Console.Write("|");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("|");
            Console.SetCursorPosition(x-1, y + 3);
            Console.Write("---");
            Console.SetCursorPosition(x, y + 4);
            Console.Write("|");
        }
    }
}
