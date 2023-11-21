using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Plant : LivingOrganism, IReproducible
    {
        public int SunlightNeeds { get; set; }

        public Plant(int energy, int age, int size, int sunlightNeeds) : base(energy, age, size)
        {
            SunlightNeeds = sunlightNeeds;
        }

        public override void Interact(LivingOrganism other)
        {
            if (other is IReproducible && new Random().NextDouble() < 0.5)
            {
                Reproduce();
            }
        }

        public void Reproduce()
        {
            Console.WriteLine("Plant reproduced");
        }
    }
}
