using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCommissions
{
    class SalesCommissionsTest
    {
        static void Main(string[] args)
        {
            //instantiate sales commission class
            SalesCommissions commissions = new SalesCommissions();

            int[] empSalary = {700, 200, 100, 4800, 5200, 4800,
                100, 120, 300, 400, 450, 400, 450, 700, 700, 800, 1000, 1200, 900, 275}; // one-dimensional employee salary array

            commissions.WriteConstants();
            commissions.ProcessSalaries(empSalary);
           Console.ReadKey();

           
        }
    }
}
