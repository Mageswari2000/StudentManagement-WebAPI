using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Data
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int DepartmentID { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual Department Department { get; set; }
        public virtual Payment Payment  { get; set; }
        public ICollection<Student_Subject> Student_Subject { get; set; }

    }
}
