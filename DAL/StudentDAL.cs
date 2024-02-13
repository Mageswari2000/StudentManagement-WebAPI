using Microsoft.AspNetCore.Mvc;
using StudentManagement.Data;
using StudentManagement.IDAL;
using StudentManagement.Models;
using System.Xml.Linq;

namespace StudentManagement.DAL

{
    public class StudentDAL : IStudentDAL
    {
        readonly ApplicationDbContext db;
        public StudentDAL(ApplicationDbContext db) 
        { 
            this.db = db;
        }

        public string SaveStudents(StudentBO Detail)
        {
            Students obj;
            try {
                if (Detail.Id == 0)
                {
                    obj = new Students();
                    db.Students.Add(obj);

                }
                else
                {
                    obj = db.Students.FirstOrDefault(e => e.Id == Detail.Id);
                   
                }
                obj.Id = Detail.Id;
                obj.Name = Detail.Name;
                obj.Email = Detail.Email;
                obj.Age = Detail.Age;
                obj.DepartmentID = Detail.DepartmentID;
                obj.Phone = Detail.Phone;

                db.SaveChanges();
                return "saved";
            }
            catch(Exception e) {
                throw new Exception(e.InnerException.Message);
            }  

        }

       public ReturnStudentBO GetStudents()
        {
            ReturnStudentBO obj= new ReturnStudentBO();
            var returndata = from student in db.Students
                             join depart in db.Department
                             on student.DepartmentID equals depart.ID 
                             where depart.DepartmentName == "MECH" || depart.DepartmentName == "EEE"
                             select new GetStudentBO
                             {
                                 Name = student.Name,
                                 Email = student.Email,
                                 DepartmentName = depart.DepartmentName,

                             };

            obj.list = returndata.ToList();
            obj.Count = returndata.Count();
            return obj;
        }

        
    }
}
