using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02TablicePostrzepione
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // tablica postrzepiona to tablica tablic 

            string[] tab1Wym = new string[4];

            string[,] tab2Wym = new string[4, 2];

            string[][] tabTab = new string[4][];

            //tabTab[0] ==null // wszystkie elementy w tym momencie są null

            tabTab[0] = new string[3];

            tabTab[0][0] = "a"; // czy to jest ok ??

            tabTab[1] = new string[4];


            // statsystka  90% tablice 1-wym , 9% dwu lub postzrepione, <1% ponad 2 wymirowe

        }
    }
}
