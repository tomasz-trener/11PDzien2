using P10Interfejsy.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10Interfejsy
{
    internal class Samochod : IUmiejacyJezdzic
    {
        public void Jedz()
        {
            Console.WriteLine("Jadzie samochod");
        }
    }
}
