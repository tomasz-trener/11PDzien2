using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadaniaManagerZawodnikow
{

    public enum TypImportu
    {
        Lokalny,
        Zdalny,
        Inny
    }

    public class ManagerZawodnikow
    {
        public Zawodnik[] Zawodnicy;
        string url;
        public TypImportu TypImportu;

        //ctor + tab tab skrót do tworzenia konstuktora 
        /// <summary>
        /// Domyslne ustawienia
        /// </summary>
        public ManagerZawodnikow()
        {
            TypImportu = TypImportu.Zdalny;
            url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
        }
        /// <summary>
        /// Import danych z adresu url
        /// </summary>
        /// <param name="url">Podaj adres do pliku</param>
        public ManagerZawodnikow(string url, TypImportu typImportu)
        {
            TypImportu = typImportu;
            this.url = url;
        }

        public WynikImportu ImportujZawodnikow()
        {
            if (TypImportu == TypImportu.Zdalny)
            {

            }
            else if (TypImportu == TypImportu.Lokalny)
            {

            }
            else if (TypImportu == TypImportu.Inny)
            {

            }
            else
            {
                throw new NotImplementedException("Opcja zimplementowana");
            }
                
            WebClient wc = new WebClient();
            string dane = wc.DownloadString(url);

            string[] wiersze = dane.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            //Zawodnicy = new Zawodnik[wiersze.Length - 1];
            List<Zawodnik> zawodnicy = new List<Zawodnik>();

            List<string> bledneWiersze = new List<string>();

            // immport danych
            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');

                try
                {
                    Zawodnik z = new Zawodnik(komorki[2], komorki[3]);

                    z.Id_zawodnika = Convert.ToInt32(komorki[0]);

                    // if (!string.IsNullOrWhiteSpace(komorki[1]))
                    z.Id_trenera = Convert.ToInt32(komorki[1]);

                    z.Kraj = komorki[4];
                    z.DataUrodzenia = Convert.ToDateTime(komorki[5]);
                    z.Wzrost = Convert.ToInt32(komorki[6]);
                    z.Waga = Convert.ToInt32(komorki[7]);

                    // Zawodnicy[i - 1] = z;
                    zawodnicy.Add(z);
                }
                catch (Exception)
                {
                    bledneWiersze.Add(wiersze[i]);
                }
            }
            Zawodnicy = zawodnicy.ToArray();
            return new WynikImportu()
            {
                Poprawny = bledneWiersze.Count == 0 ? true : false,
                BledneWiersze = bledneWiersze.ToArray()
            };

        }

    }
}
