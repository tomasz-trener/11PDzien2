using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15ObslugaBledow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int[] c = new int[2];

            try
            {
                int b = 10 / a;
                c[3] = 4;
               
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Coś nie tak z zbiorem danych");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Coś nie tak z liczniem");
            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex.Message);
                Console.WriteLine("Niepoprawne dane wejsciowe");
            }
            finally
            {
                Console.WriteLine("Wykona sie zawsze");
            }

            

            Console.ReadKey();




        }
    }
}
