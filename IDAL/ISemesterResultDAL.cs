using StudentManagement.Models;

namespace StudentManagement.IDAL
{
    public interface ISemesterResultDAL
    {
        public void SaveSemesterResult(SemesterResultBO Detail);

        public GetSemesterResultList GetSemesterResultList();

        public string DeleteSemesterResult(int SemesterResultId);
    }
}
