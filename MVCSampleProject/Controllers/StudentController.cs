using Microsoft.AspNetCore.Mvc;

namespace MVCSampleProject.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Student_Info()
        {
            return View();
        }

    }
}
