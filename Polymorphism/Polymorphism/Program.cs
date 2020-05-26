using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // a car can be BMW, and Audi, a Porsche etc.
            // Polymorphise at work #1: Audi, BMW, Porsche
            // can all be used wherever a Car is expected. No cast is
            // required because an implicit conversion exists from a derived
            // class to its base class.
            var cars = new List<Car>
            {
                new Audi("Blue","A4",200),
                new BMW("Black","T3",100)

            };

            // Polymorphism at work #2: the virtual method Repair is
            // invoked on each of the derived classes, not the base class.

            foreach(var car in cars)
            {
                car.Repair();
            }

            Car bmwZ3 = new BMW("Black", "Z3", 200);
            Car audiA1 = new BMW("Red", "A1", 300);
            bmwZ3.ShowDetails();
            audiA1.ShowDetails();

            bmwZ3.SetCarIDinfo(123, "Daniel Muñoz");
            audiA1.SetCarIDinfo(534, "Frank");
            bmwZ3.GetCarIDInfo();
            audiA1.GetCarIDInfo();


            BMW bmwM5 = new BMW("Red", "M5", 200);
            bmwM5.ShowDetails();
            bmwM5.SetCarIDinfo(5546, "Momo");
            bmwM5.GetCarIDInfo();

            // In case of wanting to show one of the derived class
            // instances as the base one you can Cast as below.
            Car carB = bmwM5;
            carB.ShowDetails();

            //M3 m3 = new M3("Red", "M5", 200);
            //m3.Repair();


            Console.ReadKey();
        }
    }
}
