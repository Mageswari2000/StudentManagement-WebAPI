using Microsoft.AspNetCore.Mvc;
using StudentManagement.IDAL;
using StudentManagement.Models;
using System.Runtime.CompilerServices;

namespace StudentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemesterDetailsController : ControllerBase
    {
        ISemesterDetailsDAL obj;
        public SemesterDetailsController(ISemesterDetailsDAL obj)
        {
           this.obj=obj;
        }

        [HttpPost("saveSemesterDetails")] 
        public ActionResult saveSemesterDetails(SemesterDetailsBO Details)
        {
            try
            {
                obj.SaveSemesterDetails(Details);
                return Ok(200);
            }
            catch (Exception e) { 
                if(e.InnerException!=null && e.Message.Contains("inner exception")){
                    return BadRequest(e.InnerException.Message);
                }
                else
                {
                    return BadRequest(e.Message);
                }
            }
        }

        [HttpGet("getSemesterDetails")]
        public ActionResult GetSemesterDetails()
        {
            try
            {
                var data = obj.GetSemesterDetails();
                return Ok(data);
            }
            catch (Exception e)
            {
                if (e.InnerException != null && e.Message.Contains("inner exception"))
                {
                    return BadRequest(e.InnerException.Message);
                }
                else
                {
                    return BadRequest(e.Message);
                }
            }
        }

        [HttpDelete("DeleteSemester")]
        public ActionResult DeleteSemester(int SemesterDetailId)
        {
            try
            {
                var data = obj.DeleteSemester(SemesterDetailId);
                return Ok(data);
            }
            catch (Exception e)
            {
                if (e.InnerException != null && e.Message.Contains("inner exception"))
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
