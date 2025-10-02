using System;
using System.Collections.Generic;

namespace Okc_HomeWrk7
{
    class Program
    {
        static void Main()
        {
            //Task 1

            Console.WriteLine("Employees\n");
            var employees = new List<Employee>
            {
                new Manager("Ghukas", 2000),
                new Developer("Valod", 1500),
                new Designer("Sultan", 1400)
            };

            foreach (var emp in employees)
                emp.Work();

            //Task 2

            Console.WriteLine("\nAppliances\n");

            var appliances = new List<Appliance>
            {
                new TV("Philips"),
                new WashingMachine("Cool washing machine company")
            };

            foreach (var app in appliances)
            {
                app.TurnOn();
                app.TurnOff();
            }

            //Task 3

            Console.WriteLine("\nIPayable\n");

            var payables = new List<IPayable>
            {
                new Manager("Ghukas", 2000),
                new Developer("Valod", 1500),
                new Freelancer("Sultan", 800)
            };

            foreach (var p in payables)
                p.PaySalary();
        }
    }
}
