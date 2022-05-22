using Microsoft.AspNetCore.Mvc;

namespace eOPG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : Controller
    {
        #region Constructor
        private readonly ITaskService _taskService;

        public TaskController(ITaskService personService)
        {
            _taskService = personService;
        }
        #endregion


        [HttpGet(Name = "GetTask")]
        public async Task<Task> GetTask(Guid Id)
        {

            var result = await _taskService.GetTask(Id);

            return result;
        }

        [HttpGet(Name = "GetTasks")]
        public async Task<List<Task>> GetTasks(Guid personId)
        {
            var result = await _taskService.GetTasks(personId);

            return result;
        }



        [HttpPost(Name = "StoreTask")]
        public async Task<IActionResult> StoreTask(Task task)
        {

            var result = await _taskService.StoreTask(task);

            return Ok(task);
        }
    }
}
