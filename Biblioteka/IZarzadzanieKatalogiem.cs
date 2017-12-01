/*
Stwórz Interfejs IZarzadzanieKatalogiem. Dodaj w niej deklarację metod:
WyszukajPoTytule(string), WyszukajPoId(int), WypiszWszystko().
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    interface IZarzadzanieKatalogiem
    {
        void WyszukajPoTytule(string tytul);
        void WyszukajPoId(int id);
        void WypiszWszystko();
    }
}