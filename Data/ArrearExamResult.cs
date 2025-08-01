using System.Diagnostics;

namespace StudentManagement.Data
{
    public class ArrearExamResult
    {
        public int Id { get; set; }
        public int SemId { get; set; }
        public int DepartmentId { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int StudentScore { get; set; }
        public int? TotalScore { get; set; }
        public string Status { get; set; }
        public string Grade { get; set; }
        public int SemesterResultId { get; set; }
        public int ExamAttemptNumber { get; set; }
        public DateOnly ArrearExamMonthYear { get; set; }

        public virtual Students Students { get; set; }
        public virtual SemesterDetails SemesterDetails { get; set; }
        public virtual Subjects Subjects { get; set; }
        public virtual Department Department { get; set; }
        public virtual SemesterResult SemesterResult { get; set; }
    }
}
