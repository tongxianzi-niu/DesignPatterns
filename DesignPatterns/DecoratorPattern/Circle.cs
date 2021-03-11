using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Circle");
        }
    }
}
