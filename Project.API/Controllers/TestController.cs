using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application;

namespace Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestService testService;

        public TestController(ITestService testService)
        {
            this.testService = testService;
        }

        [HttpGet]
        public ActionResult<Domain.Test> Get()
        {
            return Ok(this.testService.GetData());
        }
    }
}
