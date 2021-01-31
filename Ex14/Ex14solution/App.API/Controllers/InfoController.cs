using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace App.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : ControllerBase
    {
        private readonly ILogger<InfoController> _logger;

        public InfoController(ILogger<InfoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get(int isOk = 1)
        {
            _logger.LogInformation("Get method inside Info controller called.");

            try
            {
                if (isOk == 0)
                {
                    return Ok("OK");
                }

                throw new Exception();
            }
            catch (Exception)
            {
                _logger.LogError("Something went wrong in Get method inside Info controller.");
                return BadRequest("Bad request");
            }
        }
    }
}
