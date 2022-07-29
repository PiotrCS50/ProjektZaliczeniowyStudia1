using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKoncowy
{
    abstract class Osoba
    {
        protected int MAXhp;
        protected int lvl;
        public int Hp { get; set; }
        protected string nazwa;
        public string Nazwa { 
            get
            {
                return nazwa;
            }
        }
        public Bron UzywanaBron { get; set; }
        public int MaxHp { get
            {
                return MAXhp;
            }
        }
        public int Lvl { get 
            {
                return lvl;
            }
        }

        public Osoba()
        {
            MAXhp = 100;
            Hp = 100;
            lvl = 1;
        }
        public Osoba(string nazwa, int hpMax, int lvl)
        {
            this.nazwa = nazwa;
            MAXhp = hpMax;
            Hp = hpMax;
            this.lvl = lvl;
        }

        abstract public void RysujDane();
    }
}
