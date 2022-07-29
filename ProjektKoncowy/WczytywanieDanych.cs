using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKoncowy
{
    class WczytywanieDanych
    {
        public void WczytajBron(Osoba osoba, BazaBroni bazaBroni)
        {
            bazaBroni.WyczyscListe();
            Random rand = new Random();
            int los = rand.Next(10 * osoba.Lvl, 25 * osoba.Lvl);
            int z = rand.Next(16, 25);
            int zloto = (los * z * osoba.Lvl)/10;
            Bron bron1 = new Miecz("Długi Miecz", los, zloto);
            bazaBroni.DodajBron(bron1);
            los = rand.Next(10 * osoba.Lvl, 25 * osoba.Lvl);
            z = rand.Next(16, 25);
            zloto = (los * z * osoba.Lvl) / 10;
            Bron bron2 = new Miecz("Krótki Miecz", los, zloto);
            bazaBroni.DodajBron(bron2);
            los = rand.Next(10 * osoba.Lvl, 25 * osoba.Lvl);
            z = rand.Next(16, 25);
            zloto = (los * z * osoba.Lvl) / 10;
            Bron bron3 = new Miecz("Długi Królewski", los, zloto);
            bazaBroni.DodajBron(bron3);
            los = rand.Next(10 * osoba.Lvl, 25 * osoba.Lvl);
            z = rand.Next(16, 25);
            zloto = (los * z * osoba.Lvl) / 10;
            Bron bron4 = new Topor("Topór Krasnoludzki", los, zloto);
            bazaBroni.DodajBron(bron4);
            los = rand.Next(10 * osoba.Lvl, 25 * osoba.Lvl);
            z = rand.Next(16, 25);
            zloto = (los * z * osoba.Lvl) / 10;
            Bron bron5 = new Topor("Wielki Topór", los, zloto);
            bazaBroni.DodajBron(bron5);
            los = rand.Next(10 * osoba.Lvl, 25 * osoba.Lvl);
            z = rand.Next(16, 25);
            zloto = (los * z * osoba.Lvl) / 10;
            Bron bron6 = new Topor("Toporek", los, zloto);
            bazaBroni.DodajBron(bron6);
            los = rand.Next(10 * osoba.Lvl, 25 * osoba.Lvl);
            z = rand.Next(16, 25);
            zloto = (los * z * osoba.Lvl) / 10;
            Bron bron7 = new Luk("Łuk Myśliwski", los, zloto);
            bazaBroni.DodajBron(bron7);
            los = rand.Next(10 * osoba.Lvl, 25 * osoba.Lvl);
            z = rand.Next(16, 25);
            zloto = (los * z * osoba.Lvl) / 10;
            Bron bron8 = new Luk("Łuk Elficki", los, zloto);
            bazaBroni.DodajBron(bron8);
            los = rand.Next(10 * osoba.Lvl, 25 * osoba.Lvl);
            z = rand.Next(16, 25);
            zloto = (los * z * osoba.Lvl) / 10;
            Bron bron9 = new Luk("Łuk Dedryczny", los, zloto);
            bazaBroni.DodajBron(bron9);
        }
        public void WczytajPrzeciwnikow(Osoba osoba, BazaPrzeciwnikow BP)
        {
            BP.WyczyscListe();
            Random rand = new Random();
            int hp = rand.Next(20 * osoba.Lvl, 150 * osoba.Lvl);
            int obrazenia = rand.Next(5 * osoba.Lvl, 25 * osoba.Lvl);
            Przeciwnik przeciwnik1 = new Przeciwnik("Szkieleton", hp, osoba.Lvl, "Kościsty Sztylet", obrazenia, "miecz");
            BP.DodajPrzeciwnika(przeciwnik1);
            hp = rand.Next(20 * osoba.Lvl, 150 * osoba.Lvl);
            obrazenia = rand.Next(5 * osoba.Lvl, 25 * osoba.Lvl);
            Przeciwnik przeciwnik2 = new Przeciwnik("Ogr", hp, osoba.Lvl, "Wielki Żelazny Topór", obrazenia, "topor");
            BP.DodajPrzeciwnika(przeciwnik2);
            hp = rand.Next(20 * osoba.Lvl, 150 * osoba.Lvl);
            obrazenia = rand.Next(5 * osoba.Lvl, 25 * osoba.Lvl);
            Przeciwnik przeciwnik3 = new Przeciwnik("Wściekły Kot", hp, osoba.Lvl, "Jadowity Pazur", obrazenia, "miecz");
            BP.DodajPrzeciwnika(przeciwnik3);
            hp = rand.Next(20 * osoba.Lvl, 150 * osoba.Lvl);
            obrazenia = rand.Next(5 * osoba.Lvl, 25 * osoba.Lvl);
            Przeciwnik przeciwnik4 = new Przeciwnik("Zwinny Elf", hp, osoba.Lvl, "Łuk Z Leszczyny", obrazenia, "luk");
            BP.DodajPrzeciwnika(przeciwnik4);
            hp = rand.Next(20 * osoba.Lvl, 150 * osoba.Lvl);
            obrazenia = rand.Next(5 * osoba.Lvl, 25 * osoba.Lvl);
            Przeciwnik przeciwnik5 = new Przeciwnik("Wojownik Ninja", hp, osoba.Lvl, "Katana", obrazenia, "miecz");
            BP.DodajPrzeciwnika(przeciwnik5);
            hp = rand.Next(20 * osoba.Lvl, 150 * osoba.Lvl);
            obrazenia = rand.Next(5 * osoba.Lvl, 25 * osoba.Lvl);
            Przeciwnik przeciwnik6 = new Przeciwnik("Rycerz Słońca", hp, osoba.Lvl, "Niebiański Topór", obrazenia, "topor");
            BP.DodajPrzeciwnika(przeciwnik6);
            hp = rand.Next(20 * osoba.Lvl, 150 * osoba.Lvl);
            obrazenia = rand.Next(5 * osoba.Lvl, 25 * osoba.Lvl);
            Przeciwnik przeciwnik7 = new Przeciwnik("Leśny Skrzat", hp, osoba.Lvl, "Drewniany Łuk", obrazenia, "luk");
            BP.DodajPrzeciwnika(przeciwnik7);
            hp = rand.Next(20 * osoba.Lvl, 150 * osoba.Lvl);
            obrazenia = rand.Next(5 * osoba.Lvl, 25 * osoba.Lvl);
            Przeciwnik przeciwnik8 = new Przeciwnik("Górski Krasnolud", hp, osoba.Lvl, "Kamienny Topór", obrazenia, "topor");
            BP.DodajPrzeciwnika(przeciwnik8);
        }

    }
}
