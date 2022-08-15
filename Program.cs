using System;

namespace EmployeeWage
{
    class Program
    {
        public const int isFullTime = 0;
        public const int isPartTime = 1;

        public static int computeWage(String company, int wagePerHour, int days)
        {
            int empHr = 0;
            int wage = 0, wagePerDay = 0;

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
            Console.WriteLine("Employee Wage of " + company + "is " + wage);
            return wage;
        }
        static void Main(string[] args)
        {
            computeWage("Reliance", 20, 20);
            computeWage("TATA", 40, 20);
        }
    }
}
