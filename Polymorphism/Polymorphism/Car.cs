using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Car
    {
        protected string color { get; set; }
        protected int HP { get; set; }

        // has a relationship
        // any car can have an ID now thanks to this
        // it's a good example for game developing logic of having a code only do one action, these relationships help to have
        // a bunch of interconnected codes working "as one"
        protected CarIDinfo carIDinfo = new CarIDinfo();

        public void SetCarIDinfo(int idNum, string owner)
        {
            carIDinfo.IDNum = idNum;
            carIDinfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the ID of {0} and it's owner is {1}", carIDinfo.IDNum, carIDinfo.Owner);
        }
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
