using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPatterExercise
{
    public class Channel : ISubject
    {
        public List<IObserver> observers = new List<IObserver>();
        public string channelName;
        public string status;
        public void SetStatus(string status)
        {
            this.status = status;
        }

        public string GetStatus()
        {
            return this.status;
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
