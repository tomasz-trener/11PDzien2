using P10Interfejsy.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10Interfejsy
{
    internal class Amfibia : IUmiejacyPlynac, IUmiejacyJezdzic
    {
        public void Jedz()
        {
            Console.WriteLine("Amfibia Jedzie");
        }

        public void Plyn()
        {
            Console.WriteLine("Amfibia Plynie");
        }
    }
}
