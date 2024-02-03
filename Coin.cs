using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {
        public int Value;


        public Coin(String description, int value, int score)
        {
            this.description = description;
            this.Value = value;
            this.Score = score;
        }

        public override void Display()
        {
            Console.WriteLine("Coin" + description + "is Displayed");
        }

        public void UpdateTotalValue()
        {
            Board.TotalValue += Value;
            Console.WriteLine("Total Value is updated to: " + Board.TotalValue);
        }

        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(this.description + " Collected, Congrats!!!!");
            UpdateTotalValue();
            UpdateTotalScore();


        }

    }
}

