using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKoncowy
{
    class Piesc : Bron
    {
        public Piesc(string nazwa, int obrazenia) : base(nazwa, obrazenia)
        {

        }

        public override void Rysuj(int x, int y)
        {
            Console.SetCursorPosition(x, y + 2);
            Console.Write("O");
        }
    }
}
