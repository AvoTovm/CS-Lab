using System;

namespace Okc_HomeWrk7
{
    interface IPayable
    {
        void PaySalary();
    }

    class Freelancer : IPayable
    {
        public string Name { get; set; }
        public decimal Rate { get; set; }

        public Freelancer(string name, decimal rate)
        {
            Name = name;
            Rate = rate;
        }

        public void PaySalary()
        {
            Console.WriteLine($"Freelancer {Name} is paid - {Rate} Dram");
        }
    }
}
