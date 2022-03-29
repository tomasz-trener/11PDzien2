using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14Dziedziczenie
{
    internal class PlikSQL : Plik
    {

        public PlikSQL()
        {
            Rozszerzenie = ".sql";
        }
        
        public override void Zapisz()
        {
            Zawartosc = $"SELECT {Zawartosc} FROM Dane";

            base.Zapisz(); 
        }
    }
}
