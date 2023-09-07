using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance.Model
{
    internal class Earth : Planet
    {
        public void Nature()
        {
            Console.WriteLine("Earth is a planet that cultivates life and nature.");
        }
    }
}
