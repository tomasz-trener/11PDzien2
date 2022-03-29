using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14Dziedziczenie
{
    // rolę tej klasy jest bycie szablonem 
    internal abstract class Plik
    {
        public string Sciezka;
        public string Autor;
        public int Rozmiar;
        public string Zawartosc;
        public string Nazwa;

        protected string Rozszerzenie;

        public virtual void Zapisz()
        {
            File.WriteAllText(Sciezka + "\\" + Nazwa + Rozszerzenie, Zawartosc);
        }

        public override string ToString()
        {
            return Nazwa;
        }

    }
}
