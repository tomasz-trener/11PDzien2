using P10Interfejsy.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10Interfejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Samochod[] samochody = new Samochod[4];

            samochody[0] = new Samochod();

            IUmiejacyJezdzic[] pojazdyUmiejaceJezdzic = new IUmiejacyJezdzic[3];

            pojazdyUmiejaceJezdzic[0] = new Samochod();
            pojazdyUmiejaceJezdzic[1] = new Amfibia();
            pojazdyUmiejaceJezdzic[2] = new Samochod();
            pojazdyUmiejaceJezdzic[3] = new Amfibia();

            foreach (var p in pojazdyUmiejaceJezdzic)
            {
                p.Jedz();
            }

            Console.ReadKey();


        }
    }
}
