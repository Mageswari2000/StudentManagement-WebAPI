using Microsoft.AspNetCore.Mvc;
using StudentManagement.IDAL;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController:ControllerBase
    {
        ISubjectDAL obj;
        public  SubjectController(ISubjectDAL obj)
        {
            this.obj = obj;
        }

        [HttpPost("saveSubject")]
        public ActionResult SaveSubject(SubjectsBO Detail)
        {
            try {
                obj.SaveSubject(Detail);
                return Ok(200);
            } 
            catch (Exception e) { 
                if(e.Message.Contains("inner exception") && e.InnerException != null)
                {
                    return BadRequest(e.InnerException.Message);
                }
                else
                {
                    return BadRequest(e.Message);
                }
            }
            
        }
        [HttpDelete("deleteSubject")]
        public ActionResult DeleteStudent(int StudentId)
        {
            try
            {
                var res = obj.DeleteSubject(StudentId);
                return Ok(res);
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
            [HttpGet("getSubjectList")]
            public ActionResult GetSubjectList()
            {
                try
                {
                    var res = obj.GetSubjectList();
                    return Ok(res);
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

