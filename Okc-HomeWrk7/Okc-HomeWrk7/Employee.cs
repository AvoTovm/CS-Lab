using System;

namespace Okc_HomeWrk7
{
    class Employee : IPayable
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{Name} is working.");
        }

        public void PaySalary()
        {
            Console.WriteLine($"Employee {Name} is paid - {Salary} Dram");
        }
    }

    class Manager : Employee
    {
        public Manager(string name, decimal salary) : base(name, salary) { }

        public override void Work()
        {
            Console.WriteLine($"{Name} is managing");
        }
    }

    class Developer : Employee
    {
        public Developer(string name, decimal salary) : base(name, salary) { }

        public override void Work()
        {
            Console.WriteLine($"{Name} is codeing.");
        }
    }

    class Designer : Employee
    {
        public Designer(string name, decimal salary) : base(name, salary) { }

        public override void Work()
        {
            Console.WriteLine($"{Name} is designing.");
        }
    }
}
