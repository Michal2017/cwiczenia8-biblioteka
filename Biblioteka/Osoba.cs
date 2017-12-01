/*
Stwórz klasę Osoba z polami imie i nazwisko (mod. protected). Dodaj w klasie
konstruktor domyślny i parametryczny).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;

        public Osoba()
        {
            this.imie = "brak";
            this.nazwisko = "brak";
        }

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
}
