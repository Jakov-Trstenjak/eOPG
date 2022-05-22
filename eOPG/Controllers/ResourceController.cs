using eOPG.ClassLibrary.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace eOPG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResourceController : Controller
    {
        [HttpGet(Name = "GetResource")]
        public int Get(Guid resourceId)
        {
            return 1;
        }

        [HttpPost(Name = "StoreResource")]
        public int Get(Resource resource)
        {
            return 1;
        }
    }
}
