using EasyNetQ;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Easynetq_AspNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PublishController : ControllerBase
    {


        private readonly ILogger<PublishController> _logger;

        public PublishController(ILogger<PublishController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task Get([FromServices] IBus bus)
        {
            await bus.PubSub.PublishAsync(new DemoMessage { Title = "easynetq_sample" });
        }
    }
}
