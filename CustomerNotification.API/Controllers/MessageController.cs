using CustomerNotification.API.Orchestration;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading.Tasks;

namespace CustomerNotification.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        readonly CustomerOrchestrator _customerOrchestrator;

        public MessageController(CustomerOrchestrator customerOrchestrator)
        {
            _customerOrchestrator = customerOrchestrator ?? throw new ArgumentNullException(nameof(customerOrchestrator));
        }
       /// <summary>
       /// get  customer nofitication message by customer ID
       /// </summary>
       /// <param name="CustomerId"></param>
       /// <returns></returns>
        [HttpGet("v1/CustomerNotification/{CustomerId}")]
        public async  Task<IActionResult> GetCustomerNotificationMessage([FromRoute][Required] string CustomerId) {

                
            var response = await _customerOrchestrator.ProcessCustomerNotificationMessage(CustomerId);

                return Ok(response);
        }
    } 
}
