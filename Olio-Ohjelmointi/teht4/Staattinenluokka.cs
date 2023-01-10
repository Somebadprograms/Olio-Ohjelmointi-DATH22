using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    static class Staattinenluokka
    {
        public static void StaattinenMetodi()
        {
            Console.WriteLine("Tämä on saattinen metodi");
        }
        public static float KmToMiles(float km)
        {
            float conversionrate = 0.62137f; //1km = 0.62137 mailia
            return km * conversionrate;
        }
            
    }
}
