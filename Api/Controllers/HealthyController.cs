using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthyController : ControllerBase
    {
        private readonly ILogger<HealthyController> _logger;

        public HealthyController(ILogger<HealthyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public object Get()
        {
            return new {message = "OK"};
        }
    }
}