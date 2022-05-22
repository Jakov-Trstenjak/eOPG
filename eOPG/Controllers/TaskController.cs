using Microsoft.AspNetCore.Mvc;

namespace eOPG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
