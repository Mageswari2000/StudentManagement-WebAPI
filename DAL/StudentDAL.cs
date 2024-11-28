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
                //obj.Id = Detail.Id;
                //obj.Name = Detail.Name;
                //obj.Email = Detail.Email;
                //obj.Age = Detail.Age;
                //obj.DepartmentID = Detail.DepartmentID;
                //obj.Phone = Detail.Phone;
                //obj.DateOfBirth = Detail.DateOfBirth;

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
                             select new GetStudentBO
                             {
                                 Id = student.Id,
                                 RegNo = student.RegNo,
                                 FirstName = student.FirstName,
                                 LastName = student.LastName,
                                 DateOfBirth = student.DateOfBirth,
                                 Age = student.Age,
                                 Gender = student.Gender,
                                 Email = student.Email,
                                 Phone = student.Phone,
                                 GuardianName = student.GuardianName,
                                 GuardianPhone = student.GuardianPhone,
                                 SchlPassedOutYear = student.SchlPassedOutYear,
                                 CutOffIn12th = student.CutOffIn12th,
                                 JoiningDate = student.JoiningDate,
                                 Batch = student.Batch,
                                 DepartmentID = student.DepartmentID,
                                 DepartmentName = student.Department.DepartmentName,

                             };

            obj.list = returndata.ToList();
            obj.Count = returndata.Count();
            return obj;
        }


        public string DeleteStudents(int StudentId)
        {
            var obj = db.Students.FirstOrDefault(e => e.Id == StudentId);

            if (obj != null)
            {
                db.Students.Remove(obj);
                db.SaveChanges();
                return "Student Deleted Successfully";
            }
            else
            {
                return "Student doest not here";
            }

        }

    }
}
