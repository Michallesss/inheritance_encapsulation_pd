using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klas
{
    internal abstract class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected int wiek;

        protected Osoba(string imie, string nazwisko, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
        }
    }
}
