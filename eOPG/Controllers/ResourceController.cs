using eOPG.ClassLibrary.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace eOPG.Controllers
{
    [ApiController]
    [Route("resource")]
    public class ResourceController : Controller
    {
        #region Constructor
        private readonly IResourceService _resourceService;

        public ResourceController(IResourceService resourceService)
        {
            _resourceService = resourceService;
        }
        #endregion


        [HttpGet("getResource")]
        public int Get(Guid resourceId)
        {
            return 1;
        }

        [HttpPost("storeResource")]
        public int Get(Resource resource)
        {
            return 1;
        }
    }
}
