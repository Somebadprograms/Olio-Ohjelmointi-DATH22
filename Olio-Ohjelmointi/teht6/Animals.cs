using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    class Animals
    {
        public static int TotalAnimals { get; set; }
        public virtual string Sound { get; set; }
        public virtual void MakeSound()
        {
            Console.WriteLine("This animal makes a generic sound.");
        }
        public Animals()
        {
            TotalAnimals++;
        }
    }
}
