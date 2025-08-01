namespace StudentManagement.Data
{
    public class Department
    {
        public int ID { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentHead { get; set; }
        public string ContactEmail { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }

        public ICollection<Students> Student { get; set; }
        public ICollection<Subjects> Subjects { get; set; }
        public ICollection<Payment> Payment { get; set; }
        public ICollection<SemesterResult> SemesterResult { get; set; }
        public ICollection<ArrearExamResult> ArrearExamResult { get; set; }
        public ICollection<ConsolidateStudentDetails> ConsolidateStudentDetails { get; set; }
    }
}
