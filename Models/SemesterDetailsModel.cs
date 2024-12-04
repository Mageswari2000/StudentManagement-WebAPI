using StudentManagement.Data;

namespace StudentManagement.Models
{
    public class SemesterDetailsBO
    {
        public int ID { get; set; }
        public string SemType { get; set; }
        public int TotalSemFees { get; set; }

    }
    public class GetSemesterDetailsList
    {
       public List<SemesterDetailsBO> SemList { get; set; }
       public int? count { get; set; }

    }

}
