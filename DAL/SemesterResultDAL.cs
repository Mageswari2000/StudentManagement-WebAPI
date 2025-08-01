using StudentManagement.Data;
using StudentManagement.IDAL;
using StudentManagement.Models;

namespace StudentManagement.DAL
{
    public class SemesterResultDAL:ISemesterResultDAL
    {
        readonly ApplicationDbContext db;
        public SemesterResultDAL(ApplicationDbContext db) {
            this.db = db;
        }
        public void SaveSemesterResult(SemesterResultBO Detail)
        {
            SemesterResult semesterresultobj;
            if (Detail.Id == 0)
            {
                semesterresultobj = new SemesterResult();
                db.SemesterResult.Add(semesterresultobj);
            }
            else
            {
                semesterresultobj = db.SemesterResult.FirstOrDefault(ele => ele.Id == Detail.Id);
            }
            semesterresultobj.SemId=Detail.SemId;
            semesterresultobj.DepartmentId=Detail.DepartmentId;
            semesterresultobj.StudentId=Detail.StudentId;   
            semesterresultobj.SubjectId=Detail.SubjectId;
            semesterresultobj.StudentSubScore=Detail.StudentSubScore;
            semesterresultobj.TotalScore=Detail.TotalScore;
            semesterresultobj.MonthandYearOfExam=Detail.MonthandYearOfExam;
            //semesterresultobj.Status=Detail.Status;
            semesterresultobj.Grade=Detail.Grade;
            db.SaveChanges();
        }

        public GetSemesterResultList GetSemesterResultList()
        {
            GetSemesterResultList obj = new GetSemesterResultList();
            var list = from semR in db.SemesterResult
                       select new SemesterResultBO
                       {
                        Id = semR.Id,
                        SemId = semR.SemId,
                        DepartmentId = semR.DepartmentId,
                        StudentId = semR.StudentId,
                        SubjectId = semR.SubjectId,
                        StudentSubScore = semR.StudentSubScore,
                        TotalScore = semR.TotalScore,
                        MonthandYearOfExam = semR.MonthandYearOfExam,
                        //Status = semR.Status,
                        Grade = semR.Grade

        };
            obj.SEMResultList = list.ToList();
            obj.count = list.Count();
            return obj;

        }

        public string DeleteSemesterResult(int SemesterResultId)
        {
            var Data = db.SemesterResult.FirstOrDefault(e => e.Id == SemesterResultId);
            if (Data != null)
            {
                db.SemesterResult.Remove(Data);
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
