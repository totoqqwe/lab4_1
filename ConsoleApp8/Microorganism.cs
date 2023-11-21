using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Microorganism : LivingOrganism, IReproducible
    {
        public double ReproductionRate { get; set; }

        public Microorganism(int energy, int age, int size, double reproductionRate) : base(energy, age, size)
        {
            ReproductionRate = reproductionRate;
        }

        public override void Interact(LivingOrganism other)
        {
            if (other is IReproducible && new Random().NextDouble() < ReproductionRate)
            {
                Reproduce();
            }
        }

        public void Reproduce()
        {
            Console.WriteLine("Microorganism reproduced");
        }
    }
}
