using MultilevelInheritance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Planets planet = new Planets();
            //planet.Body();
            //Console.WriteLine("--------------------------------");
            Earth earth = new Earth();
            earth.Body();
            earth.Nature();        
            //Venus venus = new Venus();
            //venus.Neighbour(); 
            //venus.Position();
            //Console.WriteLine("-----------------------------------");
            Moon moon = new Moon();         
            moon.Neighbour();
            moon.Position();
            moon.Satellites();

        }
    }
}
