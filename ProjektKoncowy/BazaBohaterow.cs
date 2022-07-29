using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKoncowy
{
    class BazaBohaterow
    {
        List<Bohater> ListaBohaterow = new List<Bohater>();
        Bohater aktualny;

        public Bohater Aktualny 
        {
            get
            {
                return aktualny;
            } 
        }
        public void DodajBohatera()
        {
            if(ListaBohaterow.Count < 3)
                ListaBohaterow.Add(new Bohater());
            Console.Clear();
        }
        public void UsunBohatera(int id)
        {
            if(ListaBohaterow.Count >= 1)
                ListaBohaterow.RemoveAt(id);
        }

        public void AktualnyBohater(int Wybrany)
        {
            aktualny = ListaBohaterow[Wybrany];
        }

        public string DaneBohatera(int id)
        {
            return $"{ListaBohaterow[id].Nazwa} LVL: {ListaBohaterow[id].Lvl}";
        }

        public int Ilosc()
        {
            return ListaBohaterow.Count();
        }
    }
}
