using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 0;
            Console.WriteLine("Welcome to Employee Wage Computation");
            Console.WriteLine("------------------------------------");

            Random random = new Random();
            int value = random.Next(0, 2);

            if (value == isPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
