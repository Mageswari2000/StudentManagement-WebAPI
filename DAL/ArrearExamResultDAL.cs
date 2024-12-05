using StudentManagement.Data;
using StudentManagement.IDAL;
using StudentManagement.Models;

namespace StudentManagement.DAL
{
    public class ArrearExamResultDAL: IArrearExamResultDAL
    {
        readonly ApplicationDbContext db;
        public ArrearExamResultDAL(ApplicationDbContext db)
        {
            this.db = db;   
        }

            public void SaveArrearExamResult(ArrearExamResultBO Detail)
        {
            ArrearExamResult ARRresultobj;
            if (Detail.Id == 0)
            {
                ARRresultobj = new ArrearExamResult();
                db.ArrearExamResult.Add(ARRresultobj);
            }
            else
            {
                ARRresultobj = db.ArrearExamResult.FirstOrDefault(ele => ele.Id == Detail.Id);
            }
            ARRresultobj.SemId = Detail.SemId;
            ARRresultobj.DepartmentId = Detail.DepartmentId;
            ARRresultobj.StudentId = Detail.StudentId;
            ARRresultobj.SubjectId = Detail.SubjectId;
            ARRresultobj.StudentScore = Detail.StudentScore;
            ARRresultobj.TotalScore = Detail.TotalScore;
            ARRresultobj.ArrearExamMonthYear = Detail.ArrearExamMonthYear;
            ARRresultobj.Status = Detail.Status;
            ARRresultobj.Grade = Detail.Grade;
            db.SaveChanges();
        }

        public GetArrearExamResultList GetArrearExamResultList()
        {
            GetArrearExamResultList obj = new GetArrearExamResultList();
            var list = from Arr in db.ArrearExamResult
                       select new ArrearExamResultBO
                       {
                           Id = Arr.Id,
                           SemId = Arr.SemId,
                           DepartmentId = Arr.DepartmentId,
                           StudentId = Arr.StudentId,
                           SubjectId = Arr.SubjectId,
                           StudentScore = Arr.StudentScore,
                           TotalScore = Arr.TotalScore,
                           ArrearExamMonthYear = Arr.ArrearExamMonthYear,
                           Status = Arr.Status,
                           Grade = Arr.Grade

                       };
            obj.ArrResultList = list.ToList();
            obj.count = list.Count();
            return obj;

        }

        public string DeleteArrearExamResult(int ArrearExamResultId)
        {
            var Data = db.ArrearExamResult.FirstOrDefault(e => e.Id == ArrearExamResultId);
            if (Data != null)
            {
                db.ArrearExamResult.Remove(Data);
                db.SaveChanges();
                return "Deleted";
            }
            else
            {
                throw new Exception("Record Not Here");
            }
        }

    }
}
