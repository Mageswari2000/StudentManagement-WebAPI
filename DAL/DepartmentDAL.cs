using StudentManagement.Data;
using StudentManagement.IDAL;
using StudentManagement.Migrations;
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

        public int AddDepartment(DepartMentBO Detail)
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
            obj.Fees = Detail.Fees;
            db.SaveChanges();

            return 200;

        }

        public string DeleteDepartment(DepartMentBO Detail)
        {
            var obj = db.Department.FirstOrDefault(e => e.ID == Detail.ID);

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


        public List<DepartMentBO> GetDepartment()
        {
            var resultdata = (from S in db.Department
                              where S.ID != 0
                              select new DepartMentBO
                              {
                                  ID = S.ID,
                                  DepartmentName=S.DepartmentName,
                                  Fees = S.Fees,
                                 

                              }

                           ).ToList();

            return resultdata;

        }
    }
}
