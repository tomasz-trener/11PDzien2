using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01TabliceWielowymiarowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tablica1 = new string[4];

            int n = Convert.ToInt32(Console.ReadLine());

            string[,] tablica2 = new string[n, n];

            string[,,] tablica3 = new string[n,4, n];

            int wielkoscWymiaru0 = tablica2.GetLength(0);
            int wielkoscWymiaru1 = tablica2.GetLength(1);

            int dlugoscCalkowita2 = tablica2.Length; // n*n 
            int dlugoscCalkowita3 = tablica3.Length; // n*n*4

            tablica2[0, 0] = "a";
            tablica2[0, 1] = "b";
            tablica2[0, 2] = "b";

            //jezęli przekroczymy zakres tablicy 
            // to dostanimy błąd indexOutOfRangeException 

            for (int i = 0; i < wielkoscWymiaru0; i++)
            {
                for (int j = 0; j < wielkoscWymiaru1; j++)
                    Console.Write(tablica2[i,j]);

                Console.WriteLine();
            }



        }
    }
}
