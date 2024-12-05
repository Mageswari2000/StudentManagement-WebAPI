namespace StudentManagement.Data
{
    public class SemesterResult
    {
        public int Id { get; set; }
        public int SemId { get; set; }
        public int DepartmentId { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int StudentSubScore { get; set; }
        public int? TotalScore { get; set; }
        public DateOnly MonthandYearOfExam { get; set; }
        public string Status { get; set; }
        public string Grade { get; set; }
        public virtual Students students { get; set; }   
        public virtual SemesterDetails semesterDetails { get; set; }
        public virtual Department Department { get; set; }
        public virtual Subjects Subjects { get; set; }
        public ICollection<ArrearExamResult> arrearExamResult { get; set;}

    }
}
