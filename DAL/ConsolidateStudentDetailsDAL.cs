using StudentManagement.Data;
using StudentManagement.IDAL;
using StudentManagement.Models;

namespace StudentManagement.DAL
{
    public class ConsolidateStudentDetailsDAL : IConsolidateStudentDetailsDAL
    {
        readonly ApplicationDbContext db;
        public ConsolidateStudentDetailsDAL(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void SaveConsolidateStudentDetails(ConsolidateStudentDetailsBO Detail)
        {
            ConsolidateStudentDetails obj;
            if (Detail.Id == 0)
            {
                obj = new ConsolidateStudentDetails();
                db.ConsolidateStudentDetails.Add(obj);
            }
            else
            {
                obj = db.ConsolidateStudentDetails.FirstOrDefault(ele => ele.Id == Detail.Id);
            }            
            obj.Id = Detail.Id;
            obj.StudentId = Detail.StudentId;
            obj.StudentName = Detail.StudentName;
            obj.DepartmentId = Detail.DepartmentId;
            obj.NoOfArrearPending = Detail.NoOfArrearPending;
            obj.NoOfArrearCleared = Detail.NoOfArrearCleared;
            obj.TotalPapper= Detail.TotalPapper;
            obj.StudentRegNo= Detail.StudentRegNo;
            obj.PassedOutYear= Detail.PassedOutYear;
            obj.CGPA= Detail.CGPA;
            obj.Percentage= Detail.Percentage;
            obj.classification= Detail.classification;
            db.SaveChanges();
        }

        public GetConsolidateStudentDetailsList GetConsolidateStudentDetailsList()
        {
            GetConsolidateStudentDetailsList obj = new GetConsolidateStudentDetailsList();
            MarkDetailsBO markdetailList= new MarkDetailsBO();
            var list = from con in db.ConsolidateStudentDetails
                       select new ConsolidateStudentDetailsBO
                       {
                           Id = con.Id,
                           StudentId = con.StudentId,
                           StudentName = con.StudentName,
                           DepartmentId = con.DepartmentId,
                           NoOfArrearCleared = con.NoOfArrearCleared,
                           NoOfArrearPending = con.NoOfArrearPending,
                           TotalPapper = con.TotalPapper,
                           StudentRegNo = con.StudentRegNo,
                           PassedOutYear = con.PassedOutYear,
                           CGPA = con.CGPA,
                           Percentage = con.Percentage,
                           classification = con.classification,
                       /*    MarkDetails = (from semresult in db.SemesterResult
                                          join arrresult in db.ArrearExamResult 
                                          on semresult.Id equals arrresult.semesterResultId
                                          where semresult.StudentId== con.StudentId
                                          select new MarkDetailsBO
                                          {
                                              SemId = semresult.SemId,
                                              SubjectId = semresult.SubjectId,
                                              StudentSubScore = 
                                              TotalScore = 
                                              Status = 
                                              MonthandYearOfExam = semresult.MonthandYearOfExam,

                                         }
                           ).ToList()*/
                       };
            obj.List = list.ToList();
            obj.count = list.Count();
            return obj;

        }

        public string DeleteConsolidateStudentDetails(int Id)
        {
            var Data = db.ConsolidateStudentDetails.FirstOrDefault(e => e.Id == Id);
            if (Data != null)
            {
                db.ConsolidateStudentDetails.Remove(Data);
                db.SaveChanges();
                return "Deleted";
            }
            else
            {
                throw new Exception("Record Does Not Here");
            }

        }
    }
}
