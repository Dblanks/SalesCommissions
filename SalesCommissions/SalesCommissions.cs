using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCommissions
{
    class SalesCommissions
    {
        private int _perWeek; //commission per week
        private double _percentOfGross; //percent of gross sales 

        public SalesCommissions()
        {
            _perWeek = 200;
            _percentOfGross = 0.09;
        }

        public void WriteConstants()
        {
            Console.WriteLine("Commission: {0}\tPercent of Gross Pay: {1}",_perWeek, _percentOfGross);
            Console.WriteLine("__________________________________________________");
            Console.WriteLine();
        }

        //Method to process and retrieve salaries salaries
        public void ProcessSalaries(int[] salesPersonSalArray)
        {
            int[] totalSalesArray = new int[salesPersonSalArray.Length];

             Console.WriteLine("\t\tGross Sales\tTotal");
            //loop through determine salary for all sales people
            for (int i = 0; i < salesPersonSalArray.Length; i++)
            {
                Console.WriteLine("SalesPerson{0}: {1,-20} {2,5}", (i + 1), salesPersonSalArray[i], CalculateSalary(salesPersonSalArray[i]));
                totalSalesArray[i] = CalculateSalary(salesPersonSalArray[i]);
            }

            Console.WriteLine();
            //method to write and display bar chart
            OutputBarChart(totalSalesArray);

        }

        //Calculate salary
        private int CalculateSalary(int grossPay)
        {
            
            return (int)(grossPay * _percentOfGross) + _perWeek + grossPay;
        }

        //output bar chart displaying overall grade distribution
        public void OutputBarChart(int[] salaries)
        {
            Console.WriteLine("Salary Distribution: ");
            Console.WriteLine("________________________________");

            //stores frequency of salaries 
            int[] frequency = new int[11];

            //for each salary in the array, increment the appropriate frequency
            foreach(int sal in salaries)
            {
                if (sal >= 1000)
                {
                    ++frequency[10];
                }
                else if (sal >= 900 && sal <= 999)
                {
                    ++frequency[9];
                }
                else if (sal >= 800 && sal <= 899)
                {
                    ++frequency[8];
                }else if (sal >= 700 && sal <= 799)
                {
                    ++frequency[7];
                }else if(sal >= 600 && sal <= 699)
                {
                    ++frequency[6];
                }else if(sal >= 500 && sal <= 599)
                {
                    ++frequency[5];
                }else if(sal >= 400 && sal <= 499)
                {
                    ++frequency[4];
                }else if(sal >= 300 && sal <= 399)
                {
                    ++frequency[3];
                }else if(sal >= 200 && sal <= 299)
                {
                    ++frequency[2];
                }

            }
            
            //for each salary frequency, display bar in chart
            for(int count = 2; count < frequency.Length; count++)
            {
                //output bar label
                if(count >= 10)
                {
                    Console.Write("1000 and over: ");
                }
                else
                {
                    Console.Write("{0:D2}-{1:D2}: ",
                        count * 100 , (count * 100) + 99);
                }

                //display bar of equal signs 
                for(int bars = 0; bars < frequency[count]; bars++)
                {
                    Console.Write("=");
                }

                Console.WriteLine();
            }
        }
    }
}
