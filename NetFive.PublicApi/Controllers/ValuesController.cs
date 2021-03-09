using Microsoft.AspNetCore.Mvc;
using NetFive.B.Abstractions.TestB;

namespace NetFive.PublicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ITestBService _testBService;

        public ValuesController(ITestBService testBService)
        {
            _testBService = testBService;
        }

        [HttpGet]
        public IActionResult Test()
        {
            _testBService.Say();

            return Ok();
        }
    }
}
