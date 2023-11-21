using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Animal : LivingOrganism, IReproducible, IPredator
    {
        public int Speed { get; set; }

        public Animal(int energy, int age, int size, int speed) : base(energy, age, size)
        {
            Speed = speed;
        }

        public override void Interact(LivingOrganism other)
        {
            if (other is IReproducible && new Random().NextDouble() < 0.3)
            {
                Reproduce();
            }
            else if (other is IPredator && Energy > 50)
            {
                Hunt((LivingOrganism)other);
            }
        }

        public void Reproduce()
        {
            Console.WriteLine("Animal reproduced");
        }

        public void Hunt(LivingOrganism prey)
        {
            Console.WriteLine($"Animal hunted {prey.GetType().Name}");
        }
    }
}
