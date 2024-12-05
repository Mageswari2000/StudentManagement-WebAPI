namespace StudentManagement.Data
{
    public class ConsolidateStudentDetails
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int StudentId { get; set; }
        public int StudentRegNo { get; set; }
        public string StudentName { get; set; }
        public int? NoOfArrearPending { get; set; }
        public int? NoOfArrearCleared { get; set; }
        public int? TotalPapper { get; set; }
        public DateOnly? PassedOutYear { get; set; }
        public int? Percentage { get; set; }
        public int? CGPA { get; set; }
        public string  classification { get; set; }
        public virtual Students Students { get; set; }
        public  virtual Department Department { get; set; }

    }
}
