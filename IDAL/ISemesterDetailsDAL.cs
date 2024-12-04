using StudentManagement.Models;

namespace StudentManagement.IDAL
{
    public interface ISemesterDetailsDAL
    {
        public void SaveSemesterDetails(SemesterDetailsBO Detail);

        public GetSemesterDetailsList GetSemesterDetails();

        public string DeleteSemester(int SemesterDetailId);
    }
}
