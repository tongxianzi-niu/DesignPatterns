using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.CompositePattern
{
    public class Housing : IStructure
    {
        private List<IStructure> structures;
        private string address;

        public Housing(string address)
        {
            this.structures = new List<IStructure>();
            this.address = address;
        }
        public void Enter()
        {
            Console.WriteLine("You have entered the {0}.", this.GetName());
        }

        public void Exit()
        {
            Console.WriteLine("You have left the {0}.", this.GetName());
        }

        public string GetName()
        {
            return this.address;
        }

        public void Location()
        {
            Console.WriteLine("You are currently in {0}. It has ", this.GetName());
            foreach (IStructure structure in this.structures)
            {
                Console.WriteLine(structure.GetName());
            }
        }

        public int AddStructure(IStructure component)
        {
            this.structures.Add(component);
            return this.structures.Count - 1;
        }

        public IStructure GetStructure(int compNumber)
        {
            return this.structures.ElementAt(compNumber);
        }
    }
}
