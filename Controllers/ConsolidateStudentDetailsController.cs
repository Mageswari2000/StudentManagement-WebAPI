using Microsoft.AspNetCore.Mvc;
using StudentManagement.IDAL;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsolidateController:ControllerBase
    {
        IConsolidateStudentDetailsDAL obj;
        public ConsolidateController(IConsolidateStudentDetailsDAL obj) { 
            this.obj = obj;
        }

        [HttpPost("saveSaveConsolidateStudentDetails")]
        public ActionResult SaveConsolidateStudentDetails(ConsolidateStudentDetailsBO Details)
        {
            try
            {
                obj.SaveConsolidateStudentDetails(Details);
                return Ok(200);
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

        [HttpGet("getConsolidateStudentDetailsList")]
        public ActionResult GetConsolidateStudentDetailsList()
        {
            try
            {
                var data = obj.GetConsolidateStudentDetailsList();
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

        [HttpDelete("deleteConsolidateStudentDetails")]
        public ActionResult DeleteConsolidateStudentDetails(int Id)
        {
            try
            {
                var data = obj.DeleteConsolidateStudentDetails(Id);
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
