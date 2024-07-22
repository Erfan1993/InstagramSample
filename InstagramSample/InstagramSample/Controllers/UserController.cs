using Microsoft.AspNetCore.Mvc;

namespace InstagramSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : InstagramBaseController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("this is a test page as index Page");
        }

    }
}
