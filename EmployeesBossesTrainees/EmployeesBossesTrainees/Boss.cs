using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesBossesTrainees
{
    class Boss : Employee
    {
        // properties

        public string CompanyCar { get; set; }


        public Boss(string name, string firstName, string companyCar,int salary):base(name,firstName,salary)
        {
            //We don't have to initialize the values again, we can use the "base" as above
            // Property companyCar is a member of Boss, but not from Employee.
            this.CompanyCar = companyCar;

        }

        public void Lead()
        {
            Console.WriteLine("I'm {0}, the company's boss. I have acces to the {1}",this.Name,this.CompanyCar);
        }

        //public override string ToString()
        //{
        //    return String.Format("{0} - {1} - {2} - {3}", this.Name, this.FirstName, this.Salary, this.CompanyCar);
        //}


    }
}
