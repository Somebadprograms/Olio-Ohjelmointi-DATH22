using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_Ohjelmointi
{
    internal class koira
    {
        public string Nimi;
        public string Rotu;
        public int Ikä;

        public void haeTiedot()
        {
            Console.WriteLine("Koiran nimi on " + Nimi);
            Console.WriteLine("Koiran ikä on " + Ikä);
            Console.WriteLine("Koiran rotu on " + Rotu);
        }

        public void Hauku()
        {
            Console.WriteLine(Nimi + ":" + " subliment subliment");
        }


    }
}
