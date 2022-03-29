using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieTablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            string dane= new WebClient().DownloadString(url);
            string[] wiersze= dane.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            int liczbaKolumn = wiersze[0].Split(';').Length;
            int liczbaWierszy = wiersze.Length;


            // to była talca 2-wym
            string[,] tab2Wym = new string[liczbaWierszy, liczbaKolumn];

            for (int i = 0; i < liczbaWierszy; i++)
            {
                for (int j = 0; j < liczbaKolumn; j++)
                {
                    string[] komorki = wiersze[i].Split(';');
                    tab2Wym[i, j] = komorki[j];
                }
            }

            // to jest tab tablic (postrzepiona) (ang. jagged array)

            string[][] tabTab = new string[liczbaWierszy][];
            for (int i = 0; i < liczbaWierszy; i++)
                tabTab[i] = wiersze[i].Split(';');

            // a dodatkowa zaleta 
            // w przpadku list nie ma czegoś takiego jak lista 2-wymiarowa 


            // ale można zrobić listę list

            List<List<string>> listaList = new List<List<string>>();
            
            listaList.Add(new List<string>());
            listaList[0].Add("a");


        }
    }
}
