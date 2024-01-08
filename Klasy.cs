using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Klas
{
    internal class Ksiazka: Produkt
    {
        int strony;
        string autor;

        public Ksiazka(float cena, int dostepnosc, string opis, int strony, string autor)
        {
            this.cena = cena;
            this.dostepnosc = dostepnosc;
            this.opis = opis;
            this.strony = strony;
            this.autor = autor;
        }
    }

    internal class Elektronika: Produkt
    {
        public Elektronika(float cena, int dostepnosc, string opis)
        {
            this.cena = cena;
            this.dostepnosc = dostepnosc;
            this.opis = opis;
        }
    }

    internal class Odziez: Produkt
    {
        string rozmiar;

        public Odziez(float cena, int dostepnosc, string opis, string rozmiar)
        {
            this.cena = cena;
            this.dostepnosc = dostepnosc;
            this.opis = opis;
            this.rozmiar = rozmiar;
        }
    }
}
