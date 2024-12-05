using Microsoft.AspNetCore.Mvc;
using StudentManagement.IDAL;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArrearExamResultController:ControllerBase
    {
        IArrearExamResultDAL obj;
        public ArrearExamResultController(IArrearExamResultDAL obj) {
            this.obj = obj;
        }

        [HttpPost("saveArrearExamResult")]
        public ActionResult SaveArrearExamResult(ArrearExamResultBO Detail)
        {
            try
            {
                obj.SaveArrearExamResult(Detail);
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
        [HttpDelete("deleteArrearExamResult")]
        public ActionResult DeleteSemesterResult(int SemesterResultId)
        {
            try
            {
                var res = obj.DeleteArrearExamResult(SemesterResultId);
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
        [HttpGet("getArrearExamResultList")]
        public ActionResult GetSemesterResultList()
        {
            try
            {
                var res = obj.GetArrearExamResultList();
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
