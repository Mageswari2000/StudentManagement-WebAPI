using Microsoft.AspNetCore.Mvc;
using StudentManagement.IDAL;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{

    [Route("API/api/[controller]")]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        IStudentDAL obj;


        [HttpPost("savehere")]
        public ActionResult SaveStudents(StudentBO Detail)
        {
            try{
                obj.SaveStudents(Detail);
                return Ok(200);
            }
            catch(  Exception e) 
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
