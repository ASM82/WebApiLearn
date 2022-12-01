using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiLearn.Modules;

namespace WebApiLearn.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            User u1 = new User();
           // u1.TotalSalary = 90;
            return new List<User> { 
            new User{Name="Ahmad", Age=39, Id=1},
            new User{Name="Omar", Age=39, Id=2},
            new User{Name="Jameel", Age=34, Id=3}

            };
        }


    }
}
