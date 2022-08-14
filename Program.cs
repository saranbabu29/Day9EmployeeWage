using System;

namespace EmployeeWage
{
    class Program
    {
        public const int isFullTime = 0;
        public const int isPartTime = 1;
        public const int wagePerHour = 20;
        static void Main(string[] args)
        {
            int empHr;

            Console.WriteLine("Welcome to Employee Wage Computation");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");

            Random random = new Random();
            int value = random.Next(0, 2);
            switch(value)
            {
                case isFullTime:
                    empHr = 8;
                    Console.WriteLine("Employee is Full Time and Daily Wage is " + (empHr * wagePerHour));
                    break;
                case isPartTime:
                    empHr = 4;
                    Console.WriteLine("Employee is Part Time and Daily Wage is " + (empHr * wagePerHour));
                    break;
                default:
                    empHr = 0;
                    break;

            }
        }
    }
}
