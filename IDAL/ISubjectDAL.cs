using StudentManagement.Models;

namespace StudentManagement.IDAL
{
    public interface ISubjectDAL
    {
        public void SaveSubject(SubjectsBO Detail);

        public GetSubjectList GetSubjectList();

        public string DeleteSubject(int SubjectId);
    }
}
