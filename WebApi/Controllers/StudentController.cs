using Microsoft.AspNetCore.Mvc;
using StudentManagement.IDAL;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{

    [Route("API/api/[controller]")]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IStudentDAL obj;

        public StudentController(IStudentDAL obj)
        {
            this.obj = obj;
        }

        [HttpPost("saveStudent")]
        public ActionResult SaveStudents(StudentBO Detail)
        {
            try{
                var data = obj.SaveStudents(Detail);
                return Ok(data);
            }
            catch(Exception e) 
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



        [HttpGet("getStudents")]
        public ActionResult GetStudents()
        {
            try
            {
                var data = obj.GetStudents();
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

        [HttpDelete("deleteStudent")]
        public ActionResult DeleteStudents(int StudentId)
        {
            try
            {
                obj.DeleteStudent(StudentId);
                return Ok();
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
