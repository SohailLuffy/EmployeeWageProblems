using System;
using System.Collections.Generic;

namespace UC9
{
    public class CalCu
    {
        String company;
        int emprateperhr;
        int noofworkingdays;
        int maxhrinmonth;
        public CalCu(String company, int emprateperhr, int noofworkingdays, int maxhrinmonth)
        {
            this.company = company;
            this.emprateperhr = emprateperhr;
            this.noofworkingdays = noofworkingdays;
            this.maxhrinmonth = maxhrinmonth;
        }

        public void calempwage()
        {
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            int totalwage = 0;
            int emphr = 0;
            int totalemphr = 0;
            int workingdays = 0;

            while (totalemphr <= maxhrinmonth && workingdays < noofworkingdays)
            {
                workingdays++;
                Random ran = new Random();
                int empcheck = ran.Next(0, 3);
                switch (empcheck)
                {
                    case IS_FULL_TIME:
                        emphr = 8;
                        break;
                    case IS_PART_TIME:
                        emphr = 4;
                        break;
                    default:
                        emphr = 0;
                        break;
                }
                totalemphr += emphr;
                Console.WriteLine("Days:" + workingdays + "  Emp Hours:" + totalemphr);
            }
            totalwage = totalemphr * emprateperhr;
            Console.WriteLine("Total Wage For Company:" + company + " is " + totalwage);
        }

    }
    internal class UC9
    {
        static void Main(string[] args)
        {
            CalCu ob1 = new CalCu("Wipro", 230, 26, 208);
            ob1.calempwage();
            Console.WriteLine("----------------------------------------------------------------------------------------");
            CalCu ob2 = new CalCu("Infosys", 240, 27, 216);
            ob2.calempwage();
        }
    }
}