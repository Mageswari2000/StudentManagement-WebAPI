using System.Diagnostics;

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
        public String Grade { get; set; }
        public bool IsPassed { get; set; }
        public bool IsAbsent { get; set; }
        public string ResultStatus { get; set; }

        public virtual Students Students { get; set; }
        public virtual SemesterDetails SemesterDetails { get; set; }
        public virtual Department Department { get; set; }
        public virtual Subjects Subjects { get; set; }
        public ICollection<ArrearExamResult> ArrearExamResult { get; set; }
    }
}
