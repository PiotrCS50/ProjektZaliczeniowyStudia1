using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKoncowy
{
    class BazaBroni
    {
        List<Bron> ListaBroni = new List<Bron>();

        public int Ilosc()
        {
            return ListaBroni.Count();
        }
        public Bron DajBron(int id)
        {
            return ListaBroni.ElementAt(id);
        }
        public void DodajBron(Bron bron)
        {
            ListaBroni.Add(bron);
        }
        public void WyczyscListe()
        {
            ListaBroni.Clear();
        }
        public List<Bron> DajBronie()
        {
            return ListaBroni;
        }

    }
}
