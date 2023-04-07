using Microsoft.AspNetCore.Mvc;

namespace VersionedApi.Controllers.v1;

[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
[ApiVersion("1.0", Deprecated = true)]
public class UsersController : ControllerBase
{
    // GET api/v1/Users
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "Version 1 Value 1", "Version 1 Value 2" };
    }
}
