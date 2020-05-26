using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesBossesTrainees
{
    class Employee
    {
        // base properties

        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected int Salary { get; set; }

        public Employee()
        {
            Name = "X employee";
            FirstName = "X firstname";
            Salary = 0;
        }

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("I'm and employee, i'm working");
        }

        public void Pause()
        {
            Console.WriteLine("I'm in my break now");
        }

        //public override string ToString()
        //{
        //    return String.Format("{0} - {1} - {2}", this.Name, this.FirstName, this.Salary);
        //}




    }


   
}
