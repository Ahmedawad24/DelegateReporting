using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ReportDelegate
    {
        public delegate bool SaleCondition(Employee e);
        public void ProcessEmployee(Employee[] emps, string title, SaleCondition isSaleCond)
        {
            Console.WriteLine(title);
            Console.WriteLine("------------------------------");

            for (int i = 0; i < emps.Length; i++)
            {
                if (isSaleCond(emps[i]))
                {
                    Console.WriteLine($"Employee Name→{emps[i].Name} has achieved Sales of {emps[i].TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
