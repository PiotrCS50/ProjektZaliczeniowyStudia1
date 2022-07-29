using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKoncowy
{
    class Luk : Bron
    {
        public Luk(string nazwa, int obrazenia, int koszt) : base(nazwa, obrazenia, koszt)
        {

        }
        public Luk(string nazwa, int obrazenia) : base(nazwa, obrazenia)
        {

        }

        public override void Rysuj(int x, int y)
        {
            Console.SetCursorPosition(43, y);
            Console.Write("|\\");
            Console.SetCursorPosition(43, y + 1);
            Console.Write("| \\");
            Console.SetCursorPosition(43, y + 2);
            Console.Write("|  |");
            Console.SetCursorPosition(43, y + 3);
            Console.Write("| /");
            Console.SetCursorPosition(43, y + 4);
            Console.Write("|/");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("->-->");
        }

    }
}
