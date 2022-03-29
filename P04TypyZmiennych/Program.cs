using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P04TypyZmiennych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            char b = 'x';
            string c = "hej";
            double d = 8.5;
            bool e = false;

            
            
            DateTime dt = new DateTime(2022, 01, 01);
            
            DateTime dt2 = new DateTime();
            DateTime dt3 = new DateTime(2022,1,3,10,20,40);

            WebClient wc = new WebClient();
            StringBuilder sb = new StringBuilder();


            // struktury przekazywane są przez wartość
            // klasy przekazywane są przez referencje (z wyjątkiem stringa)


            int a2 = a;// a2 otrzymuję kopię liczby 7

            WebClient wc2 = wc;


            sb.Append("ala");
            sb.Append(" ma");

            string wynik = sb.ToString();


        }
    }
}
