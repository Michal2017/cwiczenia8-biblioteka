/*
Stwórz klasę Książka dziedziczącą z klasy Pozycja. Dodaj w niej prywatne pole
liczbaStron (int). Następnie dodaj pole referencyjne autor typy Autor (przechowujące
obiekty z klasy Autor). Dodaj konstruktor domyślny i parametryczny. Następnie
zaimplementuj metodę WypiszInfo().
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Ksiazka : Pozycja
    {
        private int liczbaStron;
        private Autor autor;

        public Ksiazka()
            : base()
        {
            this.liczbaStron = 0;
            this.autor = new Autor();
        }

        public Ksiazka(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron, Autor autor)
            : base(tytul, id, wydawnictwo, rokWydania)
        {
            this.liczbaStron = liczbaStron;
            this.autor = autor;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("{0}. {1}", id, tytul);
            Console.WriteLine("{0} stron", liczbaStron);
            Console.WriteLine("{0} {1}", wydawnictwo, rokWydania);
        }
    }
}
