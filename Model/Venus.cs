using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance.Model
{
    internal class Venus:Planet
    {
        public void Neighbour()
        {
          Console.WriteLine("Venus is the neighbouring planet of earth.");
        }
        public void Position()
        {
            Console.WriteLine("It is the second planet in the solar system.");
        }
    }
}
