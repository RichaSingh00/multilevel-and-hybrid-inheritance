
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.Model
{
    internal class Man
    {
        public Man()
        {
            Console.WriteLine("Default constructor of the Man");
        }
        public Man(string name)
        {
            Console.WriteLine("Parameterized constructor of the Man");
        }
        public void Play()
        {
            Console.WriteLine("Man plays");
        }
        public void Work()
        {
            Console.WriteLine("Man works");
        }
    }
}
