using StudentManagement.Data;

namespace StudentManagement.Models
{
    public class StudentBO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int DepartmentID { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }

    }

    public class GetStudentBO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string DepartmentName { get; set; }
    }

    public class ReturnStudentBO
    {
        public List<GetStudentBO> list { get; set; }
        public int Count { get; set; }
    }
}
