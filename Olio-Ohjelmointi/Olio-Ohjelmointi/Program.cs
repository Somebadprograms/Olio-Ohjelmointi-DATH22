using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_Ohjelmointi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            koira koira1 = new koira(); //luodaan uusi koira olio/instanssi
            koira1.Nimi = "Rekku";
            koira1.Rotu = "Mopsi";
            koira1.Ikä = 2;

            koira1.haeTiedot();
            koira1.Hauku();

            koira koira2 = new koira();
            koira2.Nimi = "Ali";
            koira2.Rotu = "Orja";
            koira2.Ikä = 58;

            koira2.haeTiedot();
            koira2.Hauku();

            



        }
    }
}
