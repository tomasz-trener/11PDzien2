using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15ObslugaBledow
{
    internal class Kalkulator
    {
        int waga;
        public void UstawWage(int w)
        {
            if (w > 20)
                throw new WlasnyBlad("niepoprawna waga kalkulatora");

            waga = w;

        } 
    }
}
