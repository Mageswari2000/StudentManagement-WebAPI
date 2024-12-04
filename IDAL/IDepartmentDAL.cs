using StudentManagement.Models;

namespace StudentManagement.IDAL
{
    public interface IDepartmentDAL
    {

        public int AddDepartment(DepartmentBO Detail);
        public string DeleteDepartment(int DepartmentId);

        public List<DepartmentBO> GetDepartment();
    }
}
