using Microsoft.AspNetCore.Mvc;

namespace e_OPG.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
