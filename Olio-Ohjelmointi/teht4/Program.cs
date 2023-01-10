using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Staattinenluokka.StaattinenMetodi();
            float kilonetriArvo = 143.50f;
            float mailiArvo = Staattinenluokka.KmToMiles(kilonetriArvo);
            Console.WriteLine(kilonetriArvo + "km on maileissa" + mailiArvo);
            //albumi albumi = new albumi("Evolve", "Imagine dragon", "Poprock")
            //albumi Lisääkappale(new Kappale("Idont know why", "3.05");
            //albumi Lisääkappale(new Kappale("Idont know why", "3.05");
            //albumi Lisääkappale(new Kappale("Idont know why", "3.05");
            //albumi Lisääkappale(new Kappale("Idont know why", "3.05");
            //albumi Lisääkappale(new Kappale("Idont know why", "3.05");


        }
    }
}
