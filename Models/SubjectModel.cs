using StudentManagement.Data;

namespace StudentManagement.Models
{
    public class SubjectsBO
    {
        public int Id { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int DepartmentId { get; set; }
        public int SemesterId { get; set; }
    }
    public class GetSubjectList
    {
        public List<SubjectsBO> SubjectList { get; set; }
        public int? count { get; set; }

    }
}
