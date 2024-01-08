using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klas
{
    internal class Produkt: IProdukt
    {
        public float cena;
        public int dostepnosc;
        public string opis;

        public void WysietlInfo() {
            Console.WriteLine("Cena: " + cena);
            Console.WriteLine("Dostępnośc: " + dostepnosc);
            Console.WriteLine("Opis: " + opis);
        }

        public float AktualnaCena() {
            return cena;
        }

        public int DostepnaIlosc() {
            return dostepnosc;
        }
    }
}
