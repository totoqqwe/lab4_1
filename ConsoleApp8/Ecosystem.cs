using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Ecosystem
    {
        private List<LivingOrganism> organisms;

        public Ecosystem(List<LivingOrganism> organisms)
        {
            this.organisms = organisms;
        }

        public void SimulateInteraction()
        {
            foreach (var organism in organisms)
            {
                var otherOrganism = organisms[new Random().Next(organisms.Count)];
                if (organism != otherOrganism)
                {
                    organism.Interact(otherOrganism);
                }
            }
        }
    }
}
