using Microsoft.AspNetCore.Mvc;
using StudentManagement.IDAL;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{

    [Route("API/api/[controller]")]
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {

        IPaymentDAL obj;
        public PaymentController(IPaymentDAL obj)
        {
            this.obj = obj;
        }

        [HttpPost("savehere")]
        public ActionResult AddPayment(PaymentBO Detail)
        {
            try
            {
              var returndata=  obj.AddPayment(Detail);
                return Ok(returndata);
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
        public ActionResult DeletePayment(PaymentBO Detail)
        {
            try
            {
                obj.DeletePayment(Detail);
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




        [HttpGet("getPayment")]
        public async Task<IActionResult> Getpayment(int StudentId)
        {
            try
            {
                var data = obj.Getpayment(StudentId);
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
