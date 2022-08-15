using System;

namespace EmployeeWage
{
    class Program
    {
        public const int isFullTime = 0;
        public const int isPartTime = 1;
        public const int wagePerHour = 20;
        public const int days = 20;
        public const int maxHours = 100;
        static void Main(string[] args)
        {
            int empHr;
            int wage, wagePerDay;

            Console.WriteLine("Welcome to Employee Wage Computation");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");

            if (maxHours == 100 && days == 20)
            {


                Random random = new Random();
                int value = random.Next(0, 2);
                switch (value)
                {
                    case isFullTime:
                        empHr = 8;
                        wagePerDay = empHr * wagePerHour;
                        wage = wagePerDay * days;
                        Console.WriteLine("Employee is Full Time  Wage is " + wage);
                        break;
                    case isPartTime:
                        empHr = 4;
                        wagePerDay = empHr * wagePerHour;
                        wage = wagePerDay * days;
                        Console.WriteLine("Employee is Part Time and Wage is " + wage);
                        break;
                    default:
                        empHr = 0;
                        break;

                }
            }
        }
    }
}
