using Microsoft.AspNetCore.Mvc;
using StudentManagement.Data;
using StudentManagement.IDAL;
using StudentManagement.Models;

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
            if (Detail.Id==0)
            {
                obj = new Students();
                db.Students.Add(obj);
                   
            }
            else 
            { 
                obj=db.Students.FirstOrDefault(e=>e.Id==Detail.Id);

            }


            obj.Id = Detail.Id;
            obj.Name = Detail.Name;
            obj.Email = Detail.Email;
            obj.Age = Detail.Age;
            obj.DepartmentID = Detail.DepartmentID;
            obj.Phone = Detail.Phone;
            db.SaveChangesAsync();
            return "Saved";

        }
    }
}
