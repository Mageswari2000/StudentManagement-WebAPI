namespace StudentManagement.Data
{
    public class Department
    {
        public int ID { get; set; }
        public string DepartmentName { get; set; }
        public int Fees { get; set; }

        public ICollection<Students> Student { get; set; }


    }
}
