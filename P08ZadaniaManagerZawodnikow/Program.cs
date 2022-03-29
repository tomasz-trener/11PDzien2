using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadaniaManagerZawodnikow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string s = "ala ma kota";
            // s.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);


            ManagerZawodnikow mz = new ManagerZawodnikow();
            var wynik= mz.ImportujZawodnikow();

            if (wynik.Poprawny)
            {
                foreach (var z in mz.Zawodnicy)
                    Console.WriteLine(z.PrzedstawSie2());
            }
            else
            {
                Console.WriteLine("Poprzane zaimporowane :");
                foreach (var z in mz.Zawodnicy)
                    Console.WriteLine(z.PrzedstawSie2());
                Console.WriteLine("Zle zaimnporowane to:");
                foreach (var z in wynik.BledneWiersze)
                    Console.WriteLine(z);
            }

            Console.ReadKey();

        }
    }
}
