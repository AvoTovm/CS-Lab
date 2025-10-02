using System;

namespace Okc_HomeWrk7
{
    abstract class Appliance
    {
        public string Brand { get; set; }

        protected Appliance(string brand)
        {
            Brand = brand;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();
    }

    class TV : Appliance
    {
        public TV(string brand) : base(brand) { }

        public override void TurnOn()
        {
            Console.WriteLine($"{Brand} Tv ON.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Brand} Tv OFF.");
        }
    }

    class WashingMachine : Appliance
    {
        public WashingMachine(string brand) : base(brand) { }

        public override void TurnOn()
        {
            Console.WriteLine($"{Brand} ON");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Brand} OFF");
        }
    }
}
