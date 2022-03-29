using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07ManagerZawodnikow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerZawodnikow mz = new ManagerZawodnikow();
            mz.ImportujZawodnikow();


            foreach (var z in mz.Zawodnicy)
                Console.WriteLine(z.PrzedstawSie2());
        }
    }
}
