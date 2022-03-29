using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12Interfejsy
{
    internal class Krzeslo : IComparable, ICloneable
    {
        public string Firma;
        public int Waga;

        public object Clone()
        {
            //return this.MemberwiseClone();

            return new Krzeslo()
            {
                Firma = Firma,
                Waga = Waga - 1,
            };

        }

        public int CompareTo(object obj)
        {
            Krzeslo inneKrzeslo = (Krzeslo)obj;

            return Firma.Length - inneKrzeslo.Firma.Length;


        }
    }
}
