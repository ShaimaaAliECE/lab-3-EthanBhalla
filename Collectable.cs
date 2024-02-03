using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Collectable : Displayable
    {
        public String description;
        public CollectionBoard Board;

        public virtual void AddMe(List<Collectable> Collectables)
        {
            Collectables.Add(this);
            Console.WriteLine(this.description + "Collected, Congrats!!!!");
        }
        public virtual void Display()
        {

        }
    }
}
