namespace StudentManagement.Data
{
    public class ConsolidateStudentDetails
    {
       
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int StudentId { get; set; }
        public int? NoOfArrearPending { get; set; }
        public int? NoOfArrearCleared { get; set; }
        public int? TotalPapers { get; set; }
        public DateOnly? PassedOutYear { get; set; }
        public double? Percentage { get; set; }
        public double? CGPA { get; set; }
        public string Classification { get; set; }
        public bool? HasClearedAllPapers { get; set; }
        public string Remarks { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }

        public virtual Students Students { get; set; }
        public virtual Department Department { get; set; }
    

}
}
