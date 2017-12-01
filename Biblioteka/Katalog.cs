/*
Stwórz klasę Katalog. Dodaj w niej pole dzialTematyczny (string, private). Następnie
stwórz pole referencyjne listaPozycji typu List<Pozycja> przechowujący pozycje z
katalogu.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    //Podepnij interfejs IZarzadzanieKatalogiem do klasy Katalog. Dodaj implementację metod.
    class Katalog : IZarzadzanieKatalogiem
    {
        private string dzialTematyczny;
        private List<Pozycja> listaPozycji = new List<Pozycja>();

        //Stwórz konstruktory w klasie Katalog.

        public Katalog()
        {
            this.dzialTematyczny = "brak";
        }

        public Katalog(string dzialTematyczny)
        {
            this.dzialTematyczny = dzialTematyczny;
        }

        //Następnie w klasie Katalog dodaj metodę DodajPozycje(pozycja), która będzie dodawać na listę książkę lub czasopismo.        public void DodajPozycje(Pozycja pozycja)
        {
            listaPozycji.Add(pozycja);
        }

        public void WyszukajPoTytule(string tytul)
        {
            foreach(Pozycja pozycja in listaPozycji)
            {
                if(pozycja.PokazTytul() == tytul)
                {
                    pozycja.WypiszInfo();
                }
            }
            Console.WriteLine();
        }

        public void WyszukajPoId(int id)
        {
            foreach (Pozycja pozycja in listaPozycji)
            {
                if (pozycja.PokazId() == id)
                {
                    pozycja.WypiszInfo();
                }
            }
            Console.WriteLine();
        }

        public void WypiszWszystko()
        {
            foreach(Pozycja pozycja in listaPozycji)
            {
                pozycja.WypiszInfo();
            }
            Console.WriteLine();
        }
    }
}
