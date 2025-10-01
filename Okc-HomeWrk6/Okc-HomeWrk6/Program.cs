using System;

namespace Okc_HomeWrk6
{
    class Program
    {
        static void Main()
        {
            //Task 1
            Console.WriteLine("Students\n");

            Student s1 = new Student("Valdemar", 23, 4345221);
            Student s2 = new Student("Quchak", 20);
            Student s3 = new Student();

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            Console.WriteLine($"Total amaount of students is - {Student.count}\n");

            //Task 2

            Console.WriteLine("Cars\n");
            try
            {
                Car c1 = new Car("BMW E46", 2004, 340);
                c1.Accelerate();
                c1.Brake();

                Car c2 = new Car("Ford Mustang", 1890, 400);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Car error - {ex.Message}");
            }

            //Task 3

            Console.WriteLine("\nLogger\n");

            Logger.Log("Program running");
            Logger.Log("Test t t t t ");
        }
    }
}
