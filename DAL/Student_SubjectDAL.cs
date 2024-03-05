using StudentManagement.Data;
using StudentManagement.IDAL;
using StudentManagement.Models;

namespace StudentManagement.DAL
{
    public class Student_SubjectDAL:IStudent_SubjectDAL
    {

        readonly ApplicationDbContext db;
        public Student_SubjectDAL(ApplicationDbContext db)
        {
            this.db = db;
        }

        public int GetStudentDepartment(int StudentId)
        {
            if (StudentId > 0)
            {
               var resultdata = db.Students.FirstOrDefault(ele => ele.Id == StudentId).DepartmentID;
                return resultdata;
            }
            return 0; 
        }


        public string AddSubjectToStudents(Student_SubjectBO Detail)
        {
            Student_Subject obj;
            try
            {
                if (Detail != null)
                {
                    var student = db.Students.FirstOrDefault(ele => ele.Id == Detail.StudentId);
                    var depart = db.Department.FirstOrDefault(ele => ele.ID == Detail.DepartmentId);
                    foreach (var id in Detail.SubjectList)
                    {
                        obj = new Student_Subject();
                        obj.Id = 0;
                        obj.StudentId = Detail.StudentId;
                        obj.SubjectId = id;
                        obj.DepartmentId = Detail.DepartmentId;
                        obj.Student = student;
                        obj.Department = depart;
                        obj.Subject = db.Subjects.FirstOrDefault(ele => ele.Id == id);
                        db.Student_Subject.Add(obj);
                    };
                    db.SaveChanges();
                    return "saved";
                }
                return "";
            }
            catch (Exception e)
            {
                throw new Exception(e.InnerException.Message);
            }


        }

        public List<ReturnStudent_SubjectBO> GetStudentSubjectDetails()
        {
            var result = (from detail in db.Student_Subject
                          select new ReturnStudent_SubjectBO
                          {
                              Id = detail.Id,
                              StudentId = detail.StudentId,
                              Name = detail.Student.Name,
                              Email = detail.Student.Email,
                              Phone = detail.Student.Phone,
                              DepartmentId = detail.DepartmentId,
                              DepartmentName = detail.Department.DepartmentName,
                              SubjectId = detail.SubjectId,
                              SubjectName = detail.Subject.SubjectName    
                          });
            return result.ToList();
        }
    }
}
