using Microsoft.AspNetCore.Mvc;
using StudentManagement.IDAL;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{

    [Route("API/api/[controller]")]
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        IDepartmentDAL obj;
        public DepartmentController(IDepartmentDAL obj)
        {
            this.obj = obj;
        }



        [HttpPost("savehere")]
        public ActionResult AddDepartment(DepartMentBO Detail)
        {
            try
            {
                obj.AddDepartment(Detail);
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


        [HttpDelete("deletehere")]
        public ActionResult DeleteDepartment(DepartMentBO Detail)
        {
            try
            {
                obj.DeleteDepartment(Detail);
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




        [HttpGet("getDepartment")]
        public async Task<IActionResult> GetDepartment()
        {
            try
            {
                var data = obj.GetDepartment();
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
