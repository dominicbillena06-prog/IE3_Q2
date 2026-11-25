using BSIT32E3_BILLENA_DOMINIC.DTO.Users;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BSIT32E3_BILLENA_DOMINIC.DTO
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Hello From UserController" });
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            if (id == 0) { 
                return BadRequest(new {message = "Invalid user ID"});
            }

            if (id < 0) {
                return NotFound(new { message = "User not Found" });
            
            }
            return Ok(new { message = "Hello From UserController" });
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] AddUserRequest value)
        {
            return Ok(new { message = "User Created Successfully", user = value });

        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] EditUserRequest value)
        {
            return Ok(new { message = "Edit User Request" });

        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(new { message = "No Content" });

        }
    }
}
