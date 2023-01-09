using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HArjoitus1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ajoneuvo ajoneuvo = new Ajoneuvo();

            ajoneuvo.Nimi = "Bugatti";
            ajoneuvo.Nopeus = 400;
            ajoneuvo.Renkaat = 5;

            ajoneuvo.TulostaData();

        }
        static void Tostring()
        {

        }

    }
}
