using Microsoft.AspNetCore.Mvc;

namespace Cubits_WebApi.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        [Route("GetById")]
        public IActionResult Get(int id)
        {
            return Ok($"Este es el ID:{id}");
        }

        [HttpPost]
        [Route("CreateUsers")]
        public IActionResult Post([FromBody] int id)
        {
            return Ok($"Este es el ID:{id}");
        }

        [HttpPut]
        [Route("UpdateUser")]
        public IActionResult Put([FromBody] int id)
        {
            return Ok($"Este es el ID:{id}");
        }

        [HttpDelete]
        [Route("DeleteUser")]
        public IActionResult Deletet( int id)
        {
            return Ok($"Este es el ID:{id}");
        }
    }
}
