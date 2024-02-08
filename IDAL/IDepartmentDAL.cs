using StudentManagement.Models;

namespace StudentManagement.IDAL
{
    public interface IDepartmentDAL
    {

        public int AddDepartment(DepartMentBO Detail);
        public string DeleteDepartment(DepartMentBO Detail);

        public List<DepartMentBO> GetDepartment();
    }
}
