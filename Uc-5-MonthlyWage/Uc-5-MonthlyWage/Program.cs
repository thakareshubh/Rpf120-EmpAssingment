using System;

namespace Uc_5_MonthlyWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable initialization
            int SalaryPerHr = 20;
            int empHr ;
            int TotalWage = 0;
            int FullTime = 1;
            int parttime = 2;
           
            //loop statment
            for(int i=1;i<=20;i++)
            {
                Random random = new Random();
                int check = random.Next(0, 3);

                if (check==FullTime)
                {
                    empHr = 8;
                }
                else if(check==parttime)
                {
                    empHr = 4;
                }
                else
                {
                    empHr = 0;
                }
                TotalWage=TotalWage+empHr*SalaryPerHr;
            }
            
               Console.WriteLine("Monthly Wage of Employee is: "+TotalWage);

        }
    }
}
