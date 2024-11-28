using StudentManagement.Data;

namespace StudentManagement.Models
{
    public class StudentBO
    {
        public int Id { get; set; }
        public int RegNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string GuardianName { get; set; }
        public string GuardianPhone { get; set; }
        public DateOnly SchlPassedOutYear { get; set; }
        public decimal CutOffIn12th { get; set; }
        public DateOnly JoiningDate { get; set; }
        public int Batch { get; set; }
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

    }

    public class GetStudentBO
    {
        public int Id { get; set; }
        public int RegNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string GuardianName { get; set; }
        public string GuardianPhone { get; set; }
        public DateOnly SchlPassedOutYear { get; set; }
        public decimal CutOffIn12th { get; set; }
        public DateOnly JoiningDate { get; set; }
        public int Batch { get; set; }
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }

    public class ReturnStudentBO
    {
        public List<GetStudentBO> list { get; set; }
        public int Count { get; set; }
    }
}
