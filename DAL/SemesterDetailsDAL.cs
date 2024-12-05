using StudentManagement.Data;
using StudentManagement.IDAL;
using StudentManagement.Models;

namespace StudentManagement.DAL
{
    public class SemesterDetailsDAL:ISemesterDetailsDAL
    {
        readonly ApplicationDbContext db;
        public SemesterDetailsDAL(ApplicationDbContext db) 
        { 
            this.db= db;
        }
        public void SaveSemesterDetails(SemesterDetailsBO Details)
        {
            SemesterDetails semesterDetailsobj;
            if(Details.ID == 0)
            {
                semesterDetailsobj=new SemesterDetails();
                db.SemesterDetails.Add(semesterDetailsobj);
            }
            else
            {
              semesterDetailsobj=  db.SemesterDetails.FirstOrDefault (e=>e.ID==Details.ID);
            }
            semesterDetailsobj.ID = Details.ID;
            semesterDetailsobj.SemType = Details.SemType;
            semesterDetailsobj.TotalSemFees = Details.TotalSemFees;
            db.SaveChanges();
          
        }
        public string DeleteSemester(int SemesterDetailId)
        {
            var obj=  db.SemesterDetails.FirstOrDefault(entities=>entities.ID==SemesterDetailId);
            if (obj!=null)
            {
                db.SemesterDetails.Remove(obj);
                db.SaveChanges();
                return "Student Deleted Successfully";
            }
            else
            {
                throw new Exception("Semester Type Does Not Here");
            }
        }
        public GetSemesterDetailsList GetSemesterDetails()
        {
            GetSemesterDetailsList obj=new GetSemesterDetailsList();
            var list = from sem in db.SemesterDetails
                       select new SemesterDetailsBO
                       {
                           ID = sem.ID,
                           SemType = sem.SemType,
                           TotalSemFees = sem.TotalSemFees,
                       };
           obj.SemList = list.ToList();
           obj.count = list.Count();
           return obj;
        }
    }
}
