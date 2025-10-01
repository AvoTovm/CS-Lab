using System;

namespace Okc_HomeWrk6
{
    class Car
    {
        private string _model;
        private int _year;
        private int _speed;

        public Car(string model, int year, int speed)
        {
            if (year < 1900)
            {
                throw new ArgumentOutOfRangeException();
            }

            _model = model;
            _year = year;
            _speed = speed;
        }

        public void Accelerate()
        {
            Console.WriteLine($"{_model} tested acceleration , max speed {_speed}");
        }

        public void Brake()
        {
            Console.WriteLine($"{_model} tested brakes");
        }
    }
}
