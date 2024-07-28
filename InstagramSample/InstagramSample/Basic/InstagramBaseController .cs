using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstagramSample.Basic
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class InstagramBaseController : ControllerBase 
    {

    }
}
