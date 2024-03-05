using StudentManagement.Data;

namespace StudentManagement.Models
{
    public class PaymentBO
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? DepartmentID { get; set; }
        public string? DepartmentName { get; set; }
        public int paidAmount { get; set; }
        public int? Totalfees { get; set; }
        public int? BalanceDue { get; set; }
        public string? PaymentStatus { get; set; }
    }


    public class ReturnPaymentBO
    {
        public int Id { get; set; }
        public StudentBO Student { get; set; }
        public string? DepartmentName { get; set; }
        public int paidAmount { get; set; }
        public int? Totalfees { get; set; }
        public int? BalanceDue { get; set; }
        public string? PaymentStatus { get; set; }
    }
}
