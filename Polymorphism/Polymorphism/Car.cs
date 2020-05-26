using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Car
    {
        protected string color { get; set; }
        protected int HP { get; set; }

        public Car()
        {
            color = "black";
            HP = 10000000;
        }

        public Car(string myColor, int myHP)
        {
            color = myColor;
            HP = myHP;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Color: {0} - HP: {1}",color,HP);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
