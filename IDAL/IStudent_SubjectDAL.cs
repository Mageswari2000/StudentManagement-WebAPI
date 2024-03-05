using StudentManagement.Models;

namespace StudentManagement.IDAL
{
    public interface IStudent_SubjectDAL
    {
        public int GetStudentDepartment(int StudentId);
        public string AddSubjectToStudents(Student_SubjectBO Detail);
        public List<ReturnStudent_SubjectBO> GetStudentSubjectDetails();

    }
}
