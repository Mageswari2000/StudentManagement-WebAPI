using StudentManagement.Data;
using StudentManagement.IDAL;
using StudentManagement.Models;

namespace StudentManagement.DAL
{
    public class SubjectDAL: ISubjectDAL
    {
        readonly ApplicationDbContext db;

        public  SubjectDAL(ApplicationDbContext db)
        {
           this.db = db;    
        }

        public void SaveSubject(SubjectsBO Detail)
        {
            Subjects subjectobj;
            if (Detail.Id == 0)
            {
                subjectobj = new Subjects();
                db.Subjects.Add(subjectobj);
            }
            else
            {
                subjectobj = db.Subjects.FirstOrDefault(ele => ele.Id == Detail.Id);
            }
            subjectobj.Id=Detail.Id;
            subjectobj.SubjectName = Detail.SubjectName;    
            subjectobj.SubjectCode = Detail.SubjectCode;    
            subjectobj.DepartmentId = Detail.DepartmentId;
            subjectobj.SemesterId = Detail.SemesterId;
            db.SaveChanges();
        }

        public GetSubjectList GetSubjectList()
        {
            GetSubjectList obj =new GetSubjectList();
            var list = from sub in db.Subjects
                       select new SubjectsBO
                       {
                           Id = sub.Id,
                           SubjectName = sub.SubjectName,
                           SubjectCode = sub.SubjectCode,
                           DepartmentId = sub.DepartmentId,
                           SemesterId = sub.SemesterId
                       };
                    obj.SubjectList= list.ToList();
                    obj.count =list.Count();
                    return obj;
                
        }

        public string DeleteSubject(int SubjectId)
        {
            var Data = db.Subjects.FirstOrDefault(e => e.Id == SubjectId);
            if(Data!=null)
            {
                db.Subjects.Remove(Data);
                db.SaveChanges();
                return "Deleted";
            }
            else
            {
                throw new Exception("Subject Does Not Here");
            }
        }
    }
}
