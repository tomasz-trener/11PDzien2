using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14Dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tab = new string[] { "a", "b" };

            Plik[] pliki =
            {
                new PlikCSV() { Nazwa="Jeden", Zawartosc="ala ma kota1", Sciezka = @"c:\dane\pliki"},
                new PlikHTML() { Nazwa="Dwa", Zawartosc="ala ma kota2", Sciezka = @"c:\dane\pliki"},
                new PlikSQL() { Nazwa="Trzy", Zawartosc="ala ma kota3", Sciezka = @"c:\dane\pliki"},
            };

            foreach (var p in pliki)
                p.Zapisz();


          //  Plik p2 = new Plik();
          //  string nazwa = p2.ToString();

            Plik p3 = new PlikHTML();

            ((PlikHTML)p3).Typ = "xx";
            //PlikCSV p4 = (PlikCSV)p3;


          //  new Plik();
        }
    }
}
