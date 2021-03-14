using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPatterExercise
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver observer);

        public void RemoveObserver(IObserver observer);

        public void NotifyObservers();
    }
}
