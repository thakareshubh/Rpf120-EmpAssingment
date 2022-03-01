using System;

namespace Uc_6_WorkingHrDayReached
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FullTime = 1;
            int PartTime = 2;
            int SalaryPerHr = 20;
            int MaxDayOfWorking = 20;
            int TotalWorkingHr = 100;
            int WorkingDay = 0;
            int WorkingHour = 0;
            int empHr;

            
            while(WorkingDay<=MaxDayOfWorking||WorkingHour<=TotalWorkingHr)
            {

                WorkingDay++;
                
                Random random = new Random();
                int check = random.Next(0,3);
                if (check == FullTime)
                {
                    empHr = 8;
                }
                else if (check == PartTime)
                {
                    empHr = 4;
                }
                else
                {
                    empHr = 0;
                }

                WorkingHour = WorkingHour + empHr;
            }

            int TotalSalary=WorkingHour* SalaryPerHr;
            Console.WriteLine("Total salary of Employee: "+TotalSalary);
        }
    }
}
