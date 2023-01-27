using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace HangFireTaturial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [SwaggerOperation(Summary = "Write your summary here")]
        [HttpPost]
        public IActionResult testobject([FromBody]objectone c)
        {

            return Ok();
        }
    }
    public class objectone
    {
        public string code { get; set; }
        public string nationalcode { get; set; }
    }


}
