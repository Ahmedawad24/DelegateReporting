using System;
namespace ConsoleApp1
{
    public class Report
    {
        public void ProcessAbove60(Employee[] emps)
        {
            Console.WriteLine($"Employees With $60,000+ Sales");
            Console.WriteLine("------------------------------");

            for (int i = 0; i < emps.Length; i++)
            {
                if (emps[i].TotalSales > 60000)
                {
                    Console.WriteLine($"Employee Name→{emps[i].Name} has achieved Sales of {emps[i].TotalSales}" );
                }
            }
            Console.WriteLine("\n\n");
        }
        public void ProcessBetween60and30(Employee[] emps)
        {
            Console.WriteLine($"Employees With Sales Between $60000 and $30000");
            Console.WriteLine("------------------------------");

            for (int i = 0; i < emps.Length; i++)
            {
                if (emps[i].TotalSales > 30000 && emps[i].TotalSales < 60000)
                {
                    Console.WriteLine($"Employee Name→{emps[i].Name} has achieved Sales of {emps[i].TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }
        public void ProcessLess30(Employee[] emps)
        {
            Console.WriteLine($"Employees With Sales Below $30000");
            Console.WriteLine("------------------------------");

            for (int i = 0; i < emps.Length; i++)
            {
                if (emps[i].TotalSales < 30000)
                {
                    Console.WriteLine($"Employee Name→{emps[i].Name} has achieved Sales of {emps[i].TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
