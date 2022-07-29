using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKoncowy
{
    abstract class Bron
    {
        public int Obrazenia { get; set; }
        public int Koszt { get; set; }
        public string Nazwa { get; set; }

        public Bron(string nazwa, int obrazenia, int koszt)
        {
            Obrazenia = obrazenia;
            Koszt = koszt;
            Nazwa = nazwa;
        }

        public Bron(string nazwa, int obrazenia)
        {
            Obrazenia = obrazenia;
            Nazwa = nazwa;
        }

        abstract public void Rysuj(int x, int y);

        public string DaneBronibezKosztu()
        {
            return $"{Nazwa} {Obrazenia}";
        }

        public string DaneBroniZKosztem()
        {
            return $"{Nazwa} {Obrazenia} {Koszt}";
        }
    }
}
