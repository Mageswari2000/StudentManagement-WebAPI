using StudentManagement.Models;

namespace StudentManagement.IDAL
{
    public interface IArrearExamResultDAL
    {
        public void SaveArrearExamResult(ArrearExamResultBO Detail);

        public GetArrearExamResultList GetArrearExamResultList();

        public string DeleteArrearExamResult(int ArrearExamResultId);
    }
}
