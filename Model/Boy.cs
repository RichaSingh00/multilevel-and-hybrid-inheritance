using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.Model
{
    internal class Boy:Man
    {
        public Boy() 
        {
            Console.WriteLine("Default constructor of Boy");
        }
        public Boy(string name)
        {
            Console.WriteLine("Parameterized constructor of Boy");
        }
        public new void Play()
        {
            Console.WriteLine("Boy plays");
        }
        public void Eat()
        {
            Console.WriteLine("Boy eats");
        }
    }
}
