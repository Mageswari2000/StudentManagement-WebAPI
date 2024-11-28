namespace StudentManagement.Data
{
    public class Subjects
    {
        public int Id { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public int SemesterId { get; set; }
        public virtual SemesterDetails Semester { get; set; }
        public virtual SemesterResult SemesterResult { get; set; }
        public ICollection <ArrearExamResult> ArrearExamResult { get; set; }



    }
}
