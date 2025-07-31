//using StudentManagement.Migrations;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Data
{
    public class Students
    {
        public int Id { get; set; }
        public Int32 RegNo { get; set; }
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
        public Int32 Batch { get; set; }
        public int DepartmentID { get; set; }
        public string DepartmentName {  get; set; }
        public virtual Department Department { get; set; }
        public ICollection<Payment> payment { get; set; }
        public ICollection <SemesterResult> SemesterResult { get; set; }
        public ICollection<ArrearExamResult> ArrearExamResult { get; set; }
        public virtual ConsolidateStudentDetails ConsolidateStudentDetails { get; set; }




    }
}
