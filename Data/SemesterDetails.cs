namespace StudentManagement.Data
{
    public class SemesterDetails
    {
        public int ID { get; set; }
        public string SemType { get; set; }
        public int TotalSemFees { get; set; }
        public ICollection <Subjects> Subjects { get; set; }
        public ICollection<Payment> Payment { get; set; }
        public ICollection<SemesterResult> SemesterResult { get; set; }
        public ICollection<ArrearExamResult> ArrearExamResult { get; set; }

    }
}
