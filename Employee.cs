namespace ChainOfResponsibilityPattern
{
    public class Employee
    {
        public string Name { get; set; }
        public double ApprovalLimit { get; set; }

        public Employee(string name, double approvalLimit)
        {
            Name = name;
            ApprovalLimit = approvalLimit;
        }

        public void ApproveExpenseReport(ExpenseReport expenseReport)
        {
            if (expenseReport.Amount < ApprovalLimit)
            {
                expenseReport.Status = ExpenseReportStatus.Approved;
            }
        }
    }
}
