using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKoncowy
{
    class BazaPrzeciwnikow
    {
        List<Przeciwnik> ListaPrzeciwnikow = new List<Przeciwnik>();

        public void DodajPrzeciwnika(Przeciwnik przeciwnik)
        {
            ListaPrzeciwnikow.Add(przeciwnik);
        }
        public void WyczyscListe()
        {
            ListaPrzeciwnikow.Clear();
        }
        public int DajIlosc()
        {
            return ListaPrzeciwnikow.Count();
        }
         public Przeciwnik DajPrzeciwnika(int id)
        {
            return ListaPrzeciwnikow[id];
        }
    }
}
