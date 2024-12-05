using StudentManagement.Models;

namespace StudentManagement.IDAL
{
    public interface IConsolidateStudentDetailsDAL
    {
            public void SaveConsolidateStudentDetails(ConsolidateStudentDetailsBO Detail);
            public GetConsolidateStudentDetailsList GetConsolidateStudentDetailsList();
            public string DeleteConsolidateStudentDetails(int Id); 
    }
}
