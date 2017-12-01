/*
Stwórz abstrakcyjną klasę Pozycja. Dodaj w niej pola tytuł (string), id (int),
wydawnictwo (string), rokWydania (int) - wszystkie pola z mod. protected.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    abstract class Pozycja
    {
        protected string tytul;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;

        //W klasie Pozycja dodaj konstruktor domyślny i parametryczny.

        public Pozycja()
        {
            this.tytul = "brak";
            this.id = -1;
            this.wydawnictwo = "brak";
            this.rokWydania = -1;
        }

        public Pozycja(string tytul, int id, string wydawnictwo, int rokWydania)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }

        //W klasie Pozycja dodaj deklarację abstrakcyjnej metody WypiszInfo()

        public abstract void WypiszInfo();

        public string PokazTytul()
        {
            return tytul;
        }

        public int PokazId()
        {
            return id;
        }
    }
}
