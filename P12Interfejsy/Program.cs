using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12Interfejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = { 2, 5, 6, 3, 1 };

            Array.Sort(liczby);

            Console.WriteLine(String.Join(" ", liczby));


            Krzeslo[] krzesla =
            {
                new Krzeslo() { Firma ="xyyyds"},
                new Krzeslo() { Firma ="abc"},
                new Krzeslo() { Firma ="aaaaa"},
            };

            Array.Sort(krzesla);

            foreach (var k in krzesla)
                Console.WriteLine(k.Firma);


            Krzeslo k1 = new Krzeslo() { Firma = "abc", Waga = 10 };
            //  Krzeslo k2 = k1;
            Krzeslo k2 = (Krzeslo)k1.Clone();

            // 5 min


            Console.ReadKey();
        }
    }
}
