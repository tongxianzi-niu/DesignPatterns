using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethodPattern
{
    public abstract class PastaDish
    {
        public void MakeRecipe()
        {
            BoilWater();
            AddPasta();
            CookPasta();
            DrainAndPlate();
            AddSauce();
            AddProtein();
            AddGarnish();
        }

        public abstract void AddPasta();
        public abstract void AddSauce();
        public abstract void AddProtein();
        public abstract void AddGarnish();

        private void BoilWater()
        {
            Console.WriteLine("Boiling water...");
        }

        private void CookPasta()
        {
            Console.WriteLine("Cooking pasta...");
        }

        private void DrainAndPlate()
        {
            Console.WriteLine("Draining and plating...");
        }
    }
}
