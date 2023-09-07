using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.Model
{
    internal class Toddler:Man //inheritance is denoted by : here man's properties is inherited by toddler
    {
        public new void Play()
        {
            Console.WriteLine("Toddler plays");
        }
        public void Sleep()
        {
            Console.WriteLine("Toddler sleeps");
        }
       
    }
}
