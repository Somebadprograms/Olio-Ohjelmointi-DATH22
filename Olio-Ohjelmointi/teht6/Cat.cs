using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    class Cat : Animals
    {
        public override string Sound { get; set; } = "Meow";
        public override void MakeSound()
        {
            Console.WriteLine("The cat says " + Sound);
        }
    }
}
