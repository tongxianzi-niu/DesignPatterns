using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethodPattern
{
    public class SpaghettiMeatballs : PastaDish
    {
        public override void AddGarnish()
        {
            Console.WriteLine("Add Parmesan cheese");
        }

        public override void AddPasta()
        {
            Console.WriteLine("Add spaghetti");
        }

        public override void AddProtein()
        {
            Console.WriteLine("Add meatballs");
        }

        public override void AddSauce()
        {
            Console.WriteLine("Add tomato sauce");
        }
    }
}
