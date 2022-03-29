using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P07ManagerZawodnikow
{
    internal class Program
    {
        static void Main(string[] args)
        {
                const string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

                WebClient wc = new WebClient();
                string dane = wc.DownloadString(url);

                string[] wiersze = dane.Split(new string[1] {"\r\n"},StringSplitOptions.RemoveEmptyEntries);
        
                Zawodnik[] tab = new Zawodnik[wiersze.Length-1];
            
                // immport danych
                for (int i = 1; i < wiersze.Length; i++)
                {
                    string[] komorki = wiersze[i].Split(';');

                    Zawodnik z = new Zawodnik(komorki[2],komorki[3]);

                    z.Id_zawodnika = Convert.ToInt32(komorki[0]);
                
                    if(!string.IsNullOrWhiteSpace(komorki[1]))
                        z.Id_trenera = Convert.ToInt32(komorki[1]);

                    z.Kraj = komorki[4];
                    z.DataUrodzenia = Convert.ToDateTime(komorki[5]);
                    z.Wzrost = Convert.ToInt32(komorki[6]);
                    z.Waga = Convert.ToInt32(komorki[7]);
                
                    tab[i - 1] = z;
                }

            // teraz wyswietlenei danych 
            //for (int i = 0; i < tab.Length; i++)
            //    Console.WriteLine(tab[i].PrzedstawSie2());

            foreach (var z in tab)
                Console.WriteLine(z.PrzedstawSie2());

            Console.ReadKey();
        }
    }
}
