using Microsoft.AspNetCore.Mvc;
using StudentManagement.Data;
using StudentManagement.IDAL;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
        [Route("API/api/[controller]")]
        [Route("api/[controller]")]
        [ApiController]
        public class StudentSubjectController : ControllerBase
        {
            IStudent_SubjectDAL obj;

            public StudentSubjectController(IStudent_SubjectDAL obj)
            {
                this.obj = obj;
            }

        [HttpPost("savesubjectTostudent")]
        public ActionResult AddSubjectToStudents(Student_SubjectBO Detail)
        {
            try
            {
                var data = obj.AddSubjectToStudents(Detail);
                return Ok(data);
            }
            catch (Exception e)
            {
                if (e.Message.Contains("inner exception") && e.InnerException != null)
                {
                    return BadRequest(e.InnerException.Message);
                }
                else
                {
                    return BadRequest(e.Message);
                }
            }


        }


        [HttpGet("getStudentDepartment")]
        public ActionResult GetStudentDepartment(int StudentId)
        {
            try
            {
                var data = obj.GetStudentDepartment(StudentId);
                return Ok(data);
            }
            catch (Exception e)
            {
                if (e.Message.Contains("inner exception") && e.InnerException != null)
                {
                    return BadRequest(e.InnerException.Message);
                }
                else
                {
                    return BadRequest(e.Message);
                }
            }


        }



        [HttpGet("GetStudentSubjectDetails")]
            public ActionResult GetStudentSubjectDetails()
            {
            try
            {
                    var data = obj.GetStudentSubjectDetails();
                    return Ok(data);
                }
                catch (Exception e)
                {
                    if (e.Message.Contains("inner exception") && e.InnerException != null)
                    {
                        return BadRequest(e.InnerException.Message);
                    }
                    else
                    {
                        return BadRequest(e.Message);
                    }
                }


            }

        }
    }

