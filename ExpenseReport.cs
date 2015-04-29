namespace ChainOfResponsibilityPattern
{
    public class ExpenseReport
    {
        public double Amount { get; set; }
        public ExpenseReportStatus Status { get; set; }

        public ExpenseReport(double amount)
        {
            Amount = amount;
            Status = ExpenseReportStatus.NotApproved;
        }
    }

    public enum ExpenseReportStatus
    {
        Approved,
        NotApproved
    }
}
