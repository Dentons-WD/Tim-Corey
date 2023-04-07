using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VersionedApi.Controllers.v1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [MapToApiVersion("1.0")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [MapToApiVersion("2.0")]
        public IEnumerable<string> GetV2()
        {
            return new string[] { "Version 2 value1", "Version 2 value2" };
        }
    }
}
