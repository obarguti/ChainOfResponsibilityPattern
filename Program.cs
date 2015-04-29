using System;

namespace ChainOfResponsibilityPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var employee = new Employee("Steve", 200);
            var manager = new Employee("Frank", 300);
            var executive = new Employee("Alice", 500);

            var expenseReport = new ExpenseReport(120.0);

            employee.ApproveExpenseReport(expenseReport);
            if (expenseReport.Status == ExpenseReportStatus.Approved)
            {
                Console.WriteLine(expenseReport.Status);
            }
            else
            {
                manager.ApproveExpenseReport(expenseReport);
                if (expenseReport.Status == ExpenseReportStatus.Approved)
                {
                    Console.WriteLine(expenseReport.Status);
                }
                else
                {
                    executive.ApproveExpenseReport(expenseReport);
                    if (expenseReport.Status == ExpenseReportStatus.Approved)
                    {
                        Console.WriteLine(expenseReport.Status);
                    }
                    else
                    {
                        Console.WriteLine(expenseReport.Status);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
