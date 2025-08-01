namespace StudentManagement.Data
{
    public class SemesterDetails
    {
        public int ID { get; set; }
        public int SemesterNumber { get; set; }
        public int TuitionFees { get; set; }
        public string SemesterTitle { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public ICollection<Subjects> Subjects { get; set; }
        public ICollection<Payment> Payment { get; set; }
        public ICollection<SemesterResult> SemesterResult { get; set; }
        public ICollection<ArrearExamResult> ArrearExamResult { get; set; }
    }
}
