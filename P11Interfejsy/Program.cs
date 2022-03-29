using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11Interfejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kalkulator k = new Kalkulator();

            IOperacja op = new MechanizmDodawania();

            double wynik =
                k.WykonajObliczenie(4, 5, op);



        }
    }
}
