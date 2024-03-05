namespace StudentManagement.Models
{
    public class Student_SubjectBO
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int DepartmentId { get; set; }
        public List<int> SubjectList { get; set; }
    }

    public class ReturnStudent_SubjectBO
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

    }
}
