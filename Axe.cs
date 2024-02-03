using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Axe : Tool
    {

        public Axe(String description)
        {
            this.description = description;
        }
        public override void Display()
        {
            Console.WriteLine("Axe" + description + "is used");
        }

        public override void DoAction()
        {
            Console.WriteLine("Axe is Used!!");
        }
    }
}
