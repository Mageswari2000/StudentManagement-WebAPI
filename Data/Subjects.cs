namespace StudentManagement.Data
{
    public class Subjects
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public virtual Department Department { get; set; }
        public int SemesterType { get; set; }
        public ICollection<Student_Subject> Student_Subject { get; set; }


    }
}
