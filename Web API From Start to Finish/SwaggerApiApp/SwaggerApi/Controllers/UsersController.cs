using Microsoft.AspNetCore.Mvc;

namespace SwaggerApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    // GET: api/Users
    /// <summary>
    /// Gets a list of all users in the system.
    /// </summary>
    /// <remarks>
    /// Sample Request: GET /Users
    /// Sample Response:
    /// [
    ///     {
    ///         "id": 1,
    ///         "name": "Tim Corey"
    ///     },
    ///     {
    ///         "id": 2,
    ///         "name": "Sue Storm"
    ///     }
    /// ]
    /// </remarks>
    /// <returns>A list of users.</returns>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/Users/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/Users
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/Users/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/Users/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
