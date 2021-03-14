using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern
{
    public class Subscriber : IObserver
    {
        public void Update()
        {
            Console.WriteLine("There is new update");
        }
    }
}
