using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11Interfejsy
{
    internal class MechanizmOdejmowania : IOperacja
    {
        public double WykonajOperacje(int a, int b)
        {
            return a - b;
        }
    }
}
