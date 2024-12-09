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



        [HttpPost("saveDepartment")]
        public ActionResult AddDepartment(DepartmentBO Detail)
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


        [HttpDelete("deleteDepartment")]
        public ActionResult DeleteDepartment(int DepartmentId)
        {
            try
            {
                obj.DeleteDepartment(DepartmentId);
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




        [HttpGet("getDepartments")]
        public ActionResult GetDepartment()
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
