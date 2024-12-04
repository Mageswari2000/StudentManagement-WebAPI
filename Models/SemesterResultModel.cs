using StudentManagement.Data;

namespace StudentManagement.Models
{
    public class SemesterResultBO
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
    }

    public class GetSemesterResultList
    {
        public List<SemesterResultBO> SEMResultList { get; set; }
        public int? count { get; set; }

    }
}
