using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SingletonPattern
{
    // singleton pattern is used to prevent multiple instances created
    public class Singleton
    {
        // 1. declare a private class variable, it refers to one instance of the class
        private static Singleton sltObject = null;

        // 2. hide constructor, it cannot be called from outside
        private Singleton() { }

        // 3. create a public method to replace the normal constructor, it create an instance of the class only when the instance does not exist
        public static Singleton GetOject()
        {
            if (sltObject == null)
            {
                sltObject = new Singleton();
            }

            return sltObject;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Display Singleton Message");
        }
    }
}
