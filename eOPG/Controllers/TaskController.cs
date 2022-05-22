using eOPG.ClassLibrary.Api.Models;
using eOPG.Services.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace eOPG.Controllers
{
    [ApiController]
    [Route("task")]
    public class TaskController : Controller
    {
        #region Constructor
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        #endregion


        [HttpGet("getTask")]
        public async Task<FamilyFarmTask> GetTask(Guid Id)
        {

            var result = await _taskService.GetTask(Id);

            return result;
        }

        [HttpGet("getTasksForUser")]
        public async Task<List<FamilyFarmTask>> GetTasksForUser(Guid personId)
        {

            var result = await _taskService.GetTask(personId);

            return new List<FamilyFarmTask> { };
        }
        

        [HttpPost("storeTask")]
        public async Task<IActionResult> StoreTask(FamilyFarmTask task)
        {

            var result = await _taskService.StoreTask(task);

            return Ok(result);
        }
    }
}
