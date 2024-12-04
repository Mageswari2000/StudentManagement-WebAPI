using StudentManagement.Data;
using StudentManagement.IDAL;
//using StudentManagement.Migrations;
using StudentManagement.Models;

namespace StudentManagement.DAL
{
    public class DepartmentDAL: IDepartmentDAL
    {
        readonly ApplicationDbContext db;
        public DepartmentDAL(ApplicationDbContext db)
        {
            this.db = db;
        }

        public int AddDepartment(DepartmentBO Detail)
        {
            Department obj;
            if (Detail.ID == 0)
            {
                obj = new Department();
                db.Department.Add(obj);


            }
            else
            {
                obj = db.Department.FirstOrDefault(e => e.ID == Detail.ID);

            }


            obj.ID = Detail.ID;
            obj.DepartmentName = Detail.DepartmentName;
            db.SaveChanges();

            return 200;

        }

        public string DeleteDepartment(int DepartmentId)
        {
            var obj = db.Department.FirstOrDefault(e => e.ID == DepartmentId);

            if (obj != null)
            {
                db.Department.Remove(obj);
                db.SaveChanges();
                return "Department Deleted Successfully";
            }
            else
            {
                return "Department doest not here";
            }

        }


        public List<DepartmentBO> GetDepartment()
        {
            var resultdata = (from S in db.Department
                              where S.ID != 0
                              select new DepartmentBO
                              {
                                  ID = S.ID,
                                  DepartmentName=S.DepartmentName,
                                 
                              }

                           ).ToList();

            return resultdata;

        }
    }
}
