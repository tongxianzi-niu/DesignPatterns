using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPatterExercise
{
    public class Follower : IObserver
    {
        public string FollowerName;

        public void Update()
        {
            Console.WriteLine("There is new update");
        }
    }
}
