using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05WlasneKlasy
{
    internal class Kalkulator
    {

        // możemy tutaj (w ciele klasy)
        // zadeklarować 4 elementy 

        //1) pola -> to właściowśc (cecha) danego obiektu np. kolor, waga, typ
        //2) właściwości -> to pola ale bardziej rozbudowane 
        //3) konstruktory -> okresla w jaki sposób możemy twrzoyć kalkulator 
        //4) metody -> co dany obiekt potrafi zrobić 


        private string kolor;
        public int Waga;


        public Kalkulator(string kolor)
        {
            this.kolor = kolor;
        }


        private int dodaj(int a, int b)
        {
            string[] tab = new string[3];
            tab[0] = "a";

            return a + b;
        }

        public int Przemnoz(int a,int b)
        {
            int wynik = 0;
            for (int i = 0; i < b; i++)
            {
                wynik = dodaj(wynik, a);
            }
            return wynik;
        }


        public void MetodaNicZwracajaca()
        {



        }



    }
}
