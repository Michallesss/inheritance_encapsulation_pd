using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klas
{
    internal class Klient: Osoba
    {
        List<IProdukt> koszyk = new List<IProdukt>();

        public Klient(string imie, string nazwisko, int wiek): base(imie, nazwisko, wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
        }

        public void Dodaj(Produkt produkt) {
            if (produkt.dostepnosc > 0)
                koszyk.Add(produkt);
            else
                Console.WriteLine("Nie jest dostępny");
        }

        public float CenaOf(int index) {
           return koszyk[index].AktualnaCena();
        }

        public float Cena() { 
            float cena = 0.0f;

            foreach (Produkt produkt in koszyk)
            {
                cena += produkt.AktualnaCena();
            }

            return cena;
        }
    }
}
