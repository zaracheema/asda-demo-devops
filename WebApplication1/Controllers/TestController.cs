using Microsoft.AspNetCore.Mvc;

namespace mvcdemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly string url = "https://errordemo.azurewebsites.net/api/HttpTrigger1?code=2LbxGGg7gsnRviW0fuX4IaizXuaeoAWs1ieeI_AjlRfRAzFuTx4Uyw==";

        public TestController()
        { }

        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            var text = await response.Content.ReadAsStringAsync();

            return new OkObjectResult(text);
        }
    }
}

