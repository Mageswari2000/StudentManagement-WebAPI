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
            Student obj;
            if (Detail.Id==0)
            {
                obj = new Student();
                db.Students.Add(obj);
                   
            }
            else 
            { 
                obj=db.Students.FirstOrDefault(e=>e.Id==Detail.Id);

            }


            obj.Id = Detail.Id;
            obj.Name = Detail.Name;
            obj.FirstName = Detail.FirstName;
            obj.LastName = Detail.LastName;
            obj.Email = Detail.Email;

            return "Saved";

        }
    }
}
