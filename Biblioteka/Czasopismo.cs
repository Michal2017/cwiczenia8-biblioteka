/*
Stwórz klasę Czasopismo dziedziczącą z klasy Pozycja. Dodaj w niej prywatne pole
numer (int). Stwórz konstruktor domyślny i parametryczny oraz zaimplementuj
metodę WypiszInfo().
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Czasopismo : Pozycja
    {
        private int numer;

        public Czasopismo()
            : base()
        {
            this.numer = -1;
        }

        public Czasopismo(string tytul, int id, string wydawnictwo, int rokWydania, int numer)
            : base(tytul, id, wydawnictwo, rokWydania)
        {
            this.numer = numer;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("{0}. numer {1}: {2}", id, numer, tytul);
            Console.WriteLine("{0} {1}", wydawnictwo, rokWydania);
        }
    }
}
