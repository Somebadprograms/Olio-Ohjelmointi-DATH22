using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_Ohjelmointi
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
    internal class ttt
    {
        static void Main(string[] args)
        {
            Ajoneuvo ajoneuvo = new Ajoneuvo();

            ajoneuvo.Nimi = "Bugatti";
            ajoneuvo.Nopeus = 400;
            ajoneuvo.Renkaat = 5;

            ajoneuvo.TulostaData();
        }
    }
}
