using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class MagicWand : Tool
    {


        public MagicWand(String description)
        {
            this.description = description;
        }
        public override void Display()
        {
            Console.WriteLine("MagicWand" + description + "is used");
        }

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is Used!!");
        }
    }
}
