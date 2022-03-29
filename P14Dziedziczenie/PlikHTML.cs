using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14Dziedziczenie
{
    internal class PlikHTML : Plik
    {
        public string Typ;

        const string szablon = 
@"<html>
<body>
<p>{0}</p>
</body>
</html>";



        public PlikHTML()
        {
            Rozszerzenie = ".html";
        }

        public override void Zapisz()
        {
            Zawartosc = string.Format(szablon, Zawartosc);

            //Zawartosc = $@"<html>
            //                    <body>
            //                    <p>{Zawartosc}</p>
            //                    </body>
            //                    </html>";
            base.Zapisz();
        }
    }
}
