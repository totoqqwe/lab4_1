using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animal1 = new Animal(50, 5, 7, 8);
            var animal2 = new Animal(40, 4, 6, 7);
            var plant1 = new Plant(30, 2, 5, 6);
            var microorganism1 = new Microorganism(15, 1, 2, 0.7);

            var ecosystem = new Ecosystem(new List<LivingOrganism> { animal1, animal2, plant1, microorganism1 });

            for (int i = 0; i < 10; i++)
            {
                ecosystem.SimulateInteraction();
            }
        }
    }
}
