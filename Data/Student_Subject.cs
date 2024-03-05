namespace StudentManagement.Data
{
    public class Student_Subject
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public virtual Students Student { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public int SubjectId { get; set; }
        public virtual Subjects  Subject { get; set; }

    }
}
