using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using weTasks.Models;

namespace weTasks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UserModel>> SearchUsers()
        {
            return Ok(new List<UserModel>());
        }
    }
}
