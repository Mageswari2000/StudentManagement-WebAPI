namespace StudentManagement.Data
{
    public class SemesterDetails
    {
        public int ID { get; set; } 
        public int SemType { get; set; }
        public int TotalSemFees { get; set; }
        public DateOnly MonthandYearOfSemExam { get; set; }

        public ICollection <Subjects> Subjects { get; set; }
        public ICollection<Payment> Payment { get; set; }
        public ICollection<SemesterResult> SemesterResult { get; set; }
        public ICollection<ArrearExamResult> ArrearExamResult { get; set; }

    }
}
