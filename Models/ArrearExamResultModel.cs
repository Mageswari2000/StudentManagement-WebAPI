using StudentManagement.Data;

namespace StudentManagement.Models
{
    public class ArrearExamResultBO
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
        public DateOnly ArrearExamMonthYear { get; set; }
    }
    public class GetArrearExamResultList
    {
        public List<ArrearExamResultBO> ArrResultList { get; set; }
        public int? count { get; set; }

    }
}
