using Microsoft.AspNetCore.Mvc;

namespace Demo_WebApplication.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Hello World From ASP.NET");
        }
    }
}
