using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    // https://localhost:portnumber/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET: api/students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[]
            {
                "John", "Jane", "Jack", "Jill"
            };
            return Ok(studentNames);
        }
    }
}
