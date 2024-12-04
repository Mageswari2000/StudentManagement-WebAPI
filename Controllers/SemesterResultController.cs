using Microsoft.AspNetCore.Mvc;
using StudentManagement.Data;
using StudentManagement.IDAL;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemesterResultController:ControllerBase
    {
        ISemesterResultDAL obj;
        public SemesterResultController(ISemesterResultDAL obj)
        {
            this.obj = obj;
        }

        [HttpPost("saveSemesterResult")]
        public ActionResult SaveSemesterResult(SemesterResultBO Detail)
        {
            try
            {
                obj.SaveSemesterResult(Detail);
                return Ok(200);
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
        [HttpDelete("deleteSemesterResult")]
        public ActionResult DeleteSemesterResult(int SemesterResultId)
        {
            try
            {
                var res = obj.DeleteSemesterResult(SemesterResultId);
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
        [HttpGet("getSemesterResultList")]
        public ActionResult GetSemesterResultList()
        {
            try
            {
                var res = obj.GetSemesterResultList();
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
