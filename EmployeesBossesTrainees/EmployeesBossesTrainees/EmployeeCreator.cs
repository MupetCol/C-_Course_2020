using System;

namespace EmployeesBossesTrainees
{
    class EmployeeCreator
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Work();
            employee.Pause();

            Boss boss = new Boss("Daniel", "Muñoz", "Renault9", 5000);
            boss.Lead();

            Trainee trainee = new Trainee("Jose", "Serna", "San Carlos", 1000, 30);
            trainee.Work();
            trainee.Learn();

            Console.ReadKey();
        }

    }
}
