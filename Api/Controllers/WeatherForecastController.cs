using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceReference;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IXenonSoapApi _xeonService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _xeonService = new XenonSoapApi();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var client = new XenonServicePortTypeClient();
                //var client = _xeonService.GetInstanceAsync();
                var response = client.getCustomersListAsync();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}
