/*
Stwórz klasę Autor dziedziczącą po klasie Osoba. Dodaj w niej pole narodowosc
(mod. private). Stwórz konstruktor domyślny i parametryczny.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Autor : Osoba
    {
        private string narodowosc;

        public Autor()
            : base()
        {
            this.narodowosc = "brak";
        }

        public Autor(string imie, string nazwisko, string narodowosc)
            : base(imie, nazwisko)
        {
            this.narodowosc = narodowosc;
        }
    }
}
