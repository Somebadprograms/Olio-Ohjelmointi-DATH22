using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    class Dog : Animals
    {
        public override string Sound { get; set; } = "Woof";
        public override void MakeSound()
        {
            Console.WriteLine("The dog says " + Sound);
        }
    }
}
