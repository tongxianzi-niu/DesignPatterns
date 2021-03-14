using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethodPattern
{
    public class PenneAlfredo : PastaDish
    {
        public override void AddGarnish()
        {
            Console.WriteLine("Add parsley");
        }

        public override void AddPasta()
        {
            Console.WriteLine("Add penne");
        }

        public override void AddProtein()
        {
            Console.WriteLine("Add chicken");
        }

        public override void AddSauce()
        {
            Console.WriteLine("Add Alfredo sauce");
        }
    }
}
