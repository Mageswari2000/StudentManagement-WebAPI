namespace StudentManagement.Data
{
    public class Payment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int DepartmentId { get; set; }
        public int SemId { get; set; }
        public int paidAmount { get; set; }
        public int? BalanceDue { get; set; }
        public string PaymentStatus { get; set; }
        public string TransactionStatus { get; set; }
        public DateOnly paymentMonthandYear { get; set; }
        public DateOnly? LastDueDate { get; set; }
        public Students Students { get; set; }
        public SemesterDetails SemesterDetails { get; set; }
        public Department Department { get; set; }




    }
}

