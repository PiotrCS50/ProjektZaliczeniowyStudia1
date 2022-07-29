using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKoncowy
{
    class Topor : Bron
    {
        public Topor(string nazwa, int obrazenia, int koszt) : base(nazwa, obrazenia, koszt)
        {

        }
        public Topor(string nazwa, int obrazenia) : base(nazwa, obrazenia)
        {

        }

        public override void Rysuj(int x, int y)
        {
            Console.SetCursorPosition(x - 1, y);
            Console.Write("C|D");
            Console.SetCursorPosition(x, y + 1);
            Console.Write("|");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("|");
            Console.SetCursorPosition(x, y + 3);
            Console.Write("|");
        }
    }
}
