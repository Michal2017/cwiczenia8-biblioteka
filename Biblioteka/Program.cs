using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stwórz kilka obiektów i wywołaj dla nich wszystkie metody, aby przetestować działanie programu

            Czasopismo czasopismo1 = new Czasopismo("Tytul czasopisma 1", 1, "wydawnictwo czasopisma", 2001, 1);
            Czasopismo czasopismo2 = new Czasopismo("Tytul czasopisma 2", 2, "wydawnictwo czasopisma", 2001, 2);
            Czasopismo czasopismo3 = new Czasopismo("Tytul czasopisma 3", 3, "wydawnictwo czasopisma", 2001, 3);
            Czasopismo czasopismo4 = new Czasopismo("Tytul czasopisma 4", 4, "wydawnictwo czasopisma", 2001, 4);

            Autor autor1 = new Autor("Adam", "Kowalski", "Polska");
            Autor autor2 = new Autor("Eva", "Novac", "Wielka Brytania");

            Ksiazka ksiazka1 = new Ksiazka("Tytul ksiazki 1", 1, "wydawnictwo ksiazki", 2002, 123, autor1);
            Ksiazka ksiazka2 = new Ksiazka("Tytul ksiazki 2", 2, "wydawnictwo ksiazki", 2002, 124, autor1);
            Ksiazka ksiazka3 = new Ksiazka("Tytul ksiazki 3", 3, "wydawnictwo ksiazki", 2002, 125, autor2);
            Ksiazka ksiazka4 = new Ksiazka("Tytul ksiazki 4", 4, "wydawnictwo ksiazki", 2002, 126, autor2);

            Katalog katalog = new Katalog("Cala Biblioteka");

            katalog.DodajPozycje(czasopismo1);
            katalog.DodajPozycje(czasopismo2);
            katalog.DodajPozycje(czasopismo3);
            katalog.DodajPozycje(czasopismo4);
            katalog.DodajPozycje(ksiazka1);
            katalog.DodajPozycje(ksiazka2);
            katalog.DodajPozycje(ksiazka3);
            katalog.DodajPozycje(ksiazka4);

            katalog.WypiszWszystko();
            katalog.WyszukajPoId(1);
            katalog.WyszukajPoTytule("Tytul czasopisma 4");
            katalog.WyszukajPoTytule("Tytul ksiazi 2");

            Console.ReadKey();
        }
    }
}
