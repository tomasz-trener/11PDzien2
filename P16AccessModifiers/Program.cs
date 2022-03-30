using P16AccessModifiers.Inne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // public - dostep do elementu jest z dowolnego miejsca 
            // private - dostęp do elementu tylko i wyłącznie wewnątrz klasy 
            // protected - dostep 


            // na zewnarz klasy 

            // Czlowiek c = new Czlowiek();
            // c.Nazwisko = "y";

            //Czlowiek c = Czlowiek.StworzCzlowieka();


            Programista p = new Programista();

            Czlowiek c = new Czlowiek();
            c.Wzrost = 5;
           

        }
    }
}
