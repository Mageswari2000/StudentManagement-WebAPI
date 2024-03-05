using StudentManagement.Models;

namespace StudentManagement.IDAL
{
    public interface IStudentDAL
    {
        public string SaveStudents(StudentBO Detail);

        public ReturnStudentBO GetStudents();

        public string DeleteStudents(int StudentId);

    }
}
