using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    internal class albumi
    {
        public string albuminNimi;
        public string artisti;
        public string genre;

        private List<kappale> kappaleList;

        public albumi(string albuminNimi, string artisti, string genre, List<albumi> albumiList)
        {
            this.albuminNimi = albuminNimi;
            this.artisti = artisti;
            this.genre = genre;
            
        }
        public void Lisääkappale(kappale uusikappale)
        {
            kappaleet.Add(uusikappale);
        }
        public void TulostaTiedot()
        {
            Console.WriteLine();
            Console.WriteLine("Albumi");
            Console.WriteLine(" -Artisti " + artisti);
            Console.WriteLine(" -Albumin nimi " + albuminNimi);
            Console.WriteLine(" -Genre " + genre);

            foreach (kappale kappale in kappaleet)
            {
                kappale.TulostaTiedot();
            }

        }
    }
}
