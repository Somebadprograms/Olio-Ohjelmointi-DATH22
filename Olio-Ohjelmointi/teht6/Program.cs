using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals animals = new Animals();
            animals.häntä = true;
            animals.vari = "keltainen";
            animals.paino = 100; 
            Console.WriteLine(animals);

        }
    }
}
