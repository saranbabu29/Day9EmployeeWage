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

        public static int computeWage()
        {
            int empHr = 0;
            int wage = 0, wagePerDay = 0;

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
                        break;
                    case isPartTime:
                        empHr = 4;
                        break;
                    default:
                        empHr = 0;
                        break;

                }
                wagePerDay = empHr * wagePerHour;
                wage = wagePerDay * days;
                Console.WriteLine("Employee Wage is " + wage);
                return wage;
            }
        }
        static void Main(string[] args)
        {
            computeWage();
        }
    }
}
