using P08ZadaniaManagerZawodnikow;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09WstepLinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // linq to rozszerzenie składni jezyka c# o zapytania pseudo SQLowe 

            // do wszystkie co jest kolekjcą 

            string[] napisy = { "ala", "ma", "kota" };

            string[] wynik1 = napisy.Where(x => x.Length > 2).ToArray();

            // napisy.Select(x=>x[0]).ToArray()

            string[] wynik2 = napisy
                .Select(x => Convert.ToString(x[0]))
                .ToArray();

            string[] wynik3 = napisy
                .Select(x => x.Substring(0, 1))
                .ToArray();

            ManagerZawodnikow mz = new ManagerZawodnikow();
            mz.ImportujZawodnikow();
            var dane = mz.Zawodnicy;

            // podaj tylko polakow lub niemcow 

            var wynik4 = dane.Where(x => x.Kraj == "POL" || x.Kraj == "GER").ToArray();

            // wypisz tylko imiona i nazwiska zawodnikow jako tablica stringow

            var wynik5 = dane.Select(x => x.Imie + " " + x.Kraj).ToArray();
            File.WriteAllLines(@"c:\dane\wynik.txt", wynik5);

            var wynik6 =
            dane
                .Where(x => x.Kraj == "POL" || x.Kraj == "GER")
                .Select(x => x.Imie + " " + x.Kraj)
                .ToArray();

            GrupaKraj[] wynik7 =
                dane.GroupBy(x => x.Kraj)
                    .Select(x => new GrupaKraj()
                    {
                        NazwaKraju = x.Key,
                        SredniWzrost = x.Average(y => y.Wzrost)
                    }).ToArray();

            //foreach (var g in wynik7)
            //    Console.WriteLine(g.NazwaKraju + " " + g.SredniWzrost);

            var wynik8 =
            dane.GroupBy(x => x.Kraj)
                .Select(x => new
                {
                    MojaNazwaKraju = x.Key,
                    MojSredniWzrost = x.Average(y => y.Wzrost),
                    MojSredniaWaga = x.Average(y => y.Waga)
                }).ToArray();

            //foreach (var g in wynik8)
            //    Console.WriteLine(g.MojaNazwaKraju + " " + g.MojSredniWzrost);

            var wynik9 =
            dane.Select(x => new
            {
                Zawodnik = x,
                SredniWzrost = wynik8.FirstOrDefault(y => y.MojaNazwaKraju == x.Kraj).MojSredniWzrost
            }).ToArray();

            foreach (var z in wynik9)
                Console.WriteLine(z.Zawodnik.PrzedstawSie2() + " " + z.SredniWzrost);


            // chcemy wziac zwodnika o id = 5

            Zawodnik wynik10= dane.Where(x => x.Id_zawodnika == 5).ToArray()[0];

            Zawodnik wynik11 = dane.Where(x => x.Id_zawodnika == 5).ToArray().FirstOrDefault();

            Zawodnik wynik12 = dane.FirstOrDefault(x => x.Id_zawodnika == 5);

            var wynik13 =
            dane.Select(x => new
            {
                Imie = x.Imie,
                Kraj = x.Kraj,
                Wzrost = x.Wzrost,
                SredniWzrost = wynik8.FirstOrDefault(y => y.MojaNazwaKraju == x.Kraj).MojSredniWzrost
            }).ToArray();


            // paginacja strone k z n rekordow 
            int k = 1; // strona
            int n = 3; // liczba rekordow 

            var wynik14=
                dane
                    .OrderBy(x => x.Id_zawodnika)
                    .Skip((k - 1) * n)
                    .Take(n)
                    .ToArray();

            //12:45

            var wynik15 = (from x in dane
                          where x.Kraj == "POL"
                          select x).ToArray();


            var wynik16 = dane.Where(x => x.Kraj == "POL").ToArray();

             

            Console.ReadKey();
        }
    }
}
