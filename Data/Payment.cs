namespace StudentManagement.Data
{
    public class Payment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int DepartmentId { get; set; }
        public int SemId { get; set; }
        public int PaidAmount { get; set; }
        public int? BalanceDue { get; set; }
        public int? TotalFees { get; set; }
        public bool IsSemesterExamType { get; set; }
        public string PaymentMode { get; set; }
        public bool IsLatePayment { get; set; }
        public string PaymentStatus { get; set; }
        public string TransactionStatus { get; set; }
        public DateOnly PaymentMonthAndYear { get; set; }
        public DateOnly? LastDueDate { get; set; }
        public string ReceiptNumber { get; set; }
        public string PaidBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public  virtual Students Students { get; set; }
        public virtual SemesterDetails SemesterDetails { get; set; }
        public virtual Department Department { get; set; }
    }
}

