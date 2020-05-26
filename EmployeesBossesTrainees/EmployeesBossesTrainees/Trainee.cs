using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesBossesTrainees
{
    class Trainee : Employee
    {

        // properties
        public string SchoolHourse { get; set; }
        public int WorkingHours { get; set; }

        public Trainee(string name, string firstName, string schoolHourse, int salary, int workingHours):base(name, firstName, salary)
        {
            // Property SchoolHourse and Workinghpurs is a member of Trainees, but not from Employee.
            this.SchoolHourse = schoolHourse;
            this.WorkingHours = workingHours;

        }

        public void Learn()
        {
            Console.WriteLine("I'm a trainee, i'm learning");
        }

        public override void Work()
        {
            Console.WriteLine("I'm {0}, a trainee, i've worked for {1} hours",this.Name, this.WorkingHours);
        }

        //public override string ToString()
        //{
        //    return String.Format("{0} - {1} - {2} - {3}", this.Name, this.FirstName, this.Salary, this.SchoolHourse);
        //}
    }
   
}
