using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Audi : Car
    {
        //Properties
        private string brand = "Audi";
        public string model { get; set; }

        public Audi(string myColor,string myModel, int myHP) : base(myColor, myHP)
        {
            this.model = myModel;
        }

        private void BrandAudi()
        {

        }

        public void ShowDetails()
        {
            Console.WriteLine("Color: {0} - HP: {1} - Brand: {2}", color, HP, brand);
        }

        public override void Repair()
        {
            Console.WriteLine("The Audi {0} was repaired!", model);
        }
    }
}
