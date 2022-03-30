using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16AccessModifiers.Inne
{
    public class Czlowiek
    {
        // wewnątrz klasy 


        public Czlowiek()
        {

        }


        public Czlowiek MetodaTworzacaCzlowieka()
        {
            return new Czlowiek();
        }


        //public static Czlowiek StworzCzlowieka()
        //{
        //    return new Czlowiek();
        //}

        public string Nazwisko;
        private string imie;
        protected int Waga;
        internal int Wzrost;

        protected internal string KolorWlosow; 

        public void Metoda()
        {
            Nazwisko = "x";
            imie = "y";
        }

        public int PodajWzrost()
        {
            return Wzrost;
        }




    }
}
