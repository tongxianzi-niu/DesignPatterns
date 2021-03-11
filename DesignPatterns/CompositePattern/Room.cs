using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePattern
{
    public class Room : IStructure
    {
        public string name;

        public Room(string name)
        {
            this.name = name;
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
            return this.name;
        }

        public void Location()
        {
            Console.WriteLine("You are currently in {0}.", this.GetName());
        }
    }
}
