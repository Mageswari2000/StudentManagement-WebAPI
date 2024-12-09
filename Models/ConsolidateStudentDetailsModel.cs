using StudentManagement.Data;

namespace StudentManagement.Models
{
    public class ConsolidateStudentDetailsBO
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int StudentId { get; set; }
        public int StudentRegNo { get; set; }
        public string StudentName { get; set; }
        public int? NoOfArrearPending { get; set; }
        public int? NoOfArrearCleared { get; set; }
        public int? TotalPapper { get; set; }
        public DateOnly? PassedOutYear { get; set; }
        public int? Percentage { get; set; }
        public int? CGPA { get; set; }
        public string classification { get; set; }
        public List<MarkDetailsBO>? MarkDetails { get; set; }
    }
    public class MarkDetailsBO
    {
        public int SemId { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
        public int StudentSubScore { get; set; }
        public int? TotalScore { get; set; }
        public string Status { get; set; }
        public string Grade { get; set; }
        public DateOnly MonthandYearOfExam { get; set; }
    }
    public class GetConsolidateStudentDetailsList
    {
        public List<ConsolidateStudentDetailsBO> List { get; set; }
        public int? count { get; set; }

    }
}
