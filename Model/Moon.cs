using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance.Model
{
    internal class Moon:Venus
    {
        public void Satellites()
        {
            Console.WriteLine("Moons are natural satellites.");
        }
    }
}
