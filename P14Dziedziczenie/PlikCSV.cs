using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14Dziedziczenie
{
    internal class PlikCSV : Plik
    {
        public PlikCSV()
        {
            Rozszerzenie = ".csv";
        }
        public override void Zapisz()
        {
            Zawartosc = Zawartosc.Replace(" ", ";");

            // base odwołaj się do klasy po , której dziedziczysz (nadrzędnej)
            base.Zapisz(); 
        }
    }
}
