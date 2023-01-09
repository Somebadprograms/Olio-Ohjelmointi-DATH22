using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HArjoitus1
{
    internal class Ajoneuvo
    {
        public string Nimi;
        public int Nopeus;
        public int Renkaat;

        public void TulostaData()
        {
            Console.WriteLine("Ajoneuvo " + Nimi);
            Console.WriteLine("Huippu nopeus " + Nopeus);
            Console.WriteLine("Renkaiden määrä " + Renkaat);
        }


    }
}
