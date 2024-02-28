// SendMailController.cs

using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vehicle_Configurator.Models;
using Vehicle_Configurator.Repository;


namespace Vehicle_Configurator.Controllers
{
    [Route("api/")]
    [ApiController]
    public class SendMailController : ControllerBase
    {
        private readonly IMailService _mailService;

        public SendMailController(IMailService mailService)
        {
            _mailService = mailService;
        }


        [HttpPost("sendMail")]
        public async Task<IActionResult> SendEmail([FromBody] MailRequest request)
        {
            try
            {
                await _mailService.SendEmailAsync(request);
                return Ok("Sent Successfully");
            }
            catch (Exception ex)
            {
                // Handle exception appropriately (log, return error response, etc.)
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }
}
