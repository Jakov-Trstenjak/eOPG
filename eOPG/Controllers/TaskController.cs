using eOPG.ClassLibrary.Api.Models;
using eOPG.Services.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace eOPG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : Controller
    {
        #region Constructor
        private readonly IFamilyFarmTaskService _taskService;

        public TaskController(IFamilyFarmTaskService taskService)
        {
            _taskService = taskService;
        }
        #endregion


        [HttpGet(Name = "GetTask")]
        public async Task<FamilyFarmTask> GetTask(Guid Id)
        {

            var result = await _taskService.GetTask(Id);

            return result;
        }

        [HttpGet(Name = "GetTasks")]
        public async Task<List<FamilyFarmTask>> GetTasks(Guid personId)
        {
            var result = await _taskService.GetTasks(personId);

            return result;
        }



        [HttpPost(Name = "StoreTask")]
        public async Task<IActionResult> StoreTask(FamilyFarmTask task)
        {

            var result = await _taskService.StoreTask(task);

            return Ok(task);
        }
    }
}
