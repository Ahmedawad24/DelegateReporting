using System.Buffers;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {

            var emps = new Employee[]
            {
                new Employee { Id = 1, Name = "a", Gender = "M", TotalSales = 65000m },
                new Employee { Id = 2, Name = "b", Gender = "M", TotalSales = 50000m },
                new Employee { Id = 3, Name = "c", Gender = "F", TotalSales = 80000m },
                new Employee { Id = 4, Name = "d", Gender = "F", TotalSales = 40000m },
                new Employee { Id = 5, Name = "e", Gender = "M", TotalSales = 42000m },
                new Employee { Id = 6, Name = "f", Gender = "F", TotalSales = 15000m },
                new Employee { Id = 7, Name = "g", Gender = "M", TotalSales = 16000m },
                
            };
            //Report Without the use of the Delegate
            //Report report = new Report();
            //report.ProcessAbove60(emps);
            //report.ProcessBetween60and30(emps);
            //report.ProcessLess30(emps);
            ReportDelegate reportDelegate = new ReportDelegate();

            //Anonymous delegate
            reportDelegate.ProcessEmployee(emps, "Sales >= $60,000", delegate (Employee e) { return e.TotalSales > 60000; });

            //Delegate Using Methods
            reportDelegate.ProcessEmployee(emps, " $60,000 <= Sales >= $30,000",IsBetween);

            //Using Lambda Expression
            reportDelegate.ProcessEmployee(emps, "Sales <= $0,000",e => e.TotalSales < 30000);

            //Multicast Delegate
            RectangleHelper helper = new RectangleHelper();
            RectangleDelegate rect;
            rect = helper.GetArea;
            rect += helper.GetPerimeter;
            rect(10, 10);
            Console.WriteLine("After unsubscribing get area from delegate");
            rect -= helper.GetArea;
            rect(10,10);


            Console.ReadLine();

        }
        static bool IsBetween(Employee emp) => emp.TotalSales > 30000 && emp.TotalSales < 60000;


        //Example of MultiCast Delegate
        public delegate void RectangleDelegate(decimal width, decimal height);
        public class RectangleHelper
        {
            public void GetArea(decimal x, decimal y) { var Result = x * y; Console.WriteLine($"width→{x} Height→{y} Area→{Result}"); }
            public void GetPerimeter(decimal x, decimal y) { var Result = 2 * (x + y); Console.WriteLine($"width→{x} Height→{y} Perimeter→{Result}"); }

        }
    }

}