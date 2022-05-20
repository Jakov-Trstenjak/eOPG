using Microsoft.AspNetCore.Mvc;

namespace e_OPG.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
