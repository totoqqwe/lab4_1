using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class LivingOrganism
    {
        public int Energy { get; set; }
        public int Age { get; set; }
        public int Size { get; set; }

        public LivingOrganism(int energy, int age, int size)
        {
            Energy = energy;
            Age = age;
            Size = size;
        }

        public virtual void Interact(LivingOrganism other)
        {
        }
    }
}
