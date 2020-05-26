using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class BMW:Car
    {
        //Properties
        private string brand = "BMW";
        public string model { get; set; }

        public BMW(string myColor, string myModel, int myHP) : base(myColor, myHP)
        {
            this.model = myModel;
        }

        

        public new void ShowDetails()
        {
            Console.WriteLine("Color: {0} - HP: {1} - Brand: {2}", color, HP, brand);
        }

        public override void Repair()
        {
            Console.WriteLine("The BMW {0} was repaired!",model);
        }
    }
}
