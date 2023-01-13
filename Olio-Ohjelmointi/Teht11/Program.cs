using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, Opiskelijat> HenkilöSanakirja = new Dictionary<string, Opiskelijat>();

            Opiskelijat Andrew = new Opiskelijat("Andrew", "Tate", "DATH22", "031106-1245");
            Opiskelijat Tristan = new Opiskelijat("Tristan", "Tate", "DATH22", "120346-1345");



            try
            {
                HenkilöSanakirja.Add(Andrew.Henkilötunnus, Andrew);
                HenkilöSanakirja.Add(Tristan.Henkilötunnus, Tristan);
                HenkilöSanakirja.Add(Tristan.Henkilötunnus, Tristan);


                Console.WriteLine("Henkilöita Sanakirjassa: " + HenkilöSanakirja.Count);

                HenkilöSanakirja.Remove("031106-1245");

                Console.WriteLine("Henkilöitä Sanakirjassa: " + HenkilöSanakirja.Count);

            }
            catch (Exception e)
            {
                Console.WriteLine("VIRHE ERROR KOODI: " + e.Message);
            }
            

        }

    }
}
