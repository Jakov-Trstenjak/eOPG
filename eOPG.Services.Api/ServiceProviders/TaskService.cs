using eOPG.ClassLibrary.Api.Models;
using eOPG.Services.Api.Services;


namespace eOPG.Services.Api.ServiceProviders
{
    public class TaskService : ITaskService
    {
        #region Constructor

        private readonly ITaskService _repository;

        public TaskService(ITaskService familyFarmTaskRepository)
        {
            _repository = familyFarmTaskRepository;
        }

        #endregion


        public Task<FamilyFarmTask> GetTask(Guid familyFarmTaskId)
        {
            throw new NotImplementedException();
        }

        public Task<List<FamilyFarmTask>> GetTasks(Guid personId)
        {
            throw new NotImplementedException();
        }

        public Task<FamilyFarmTask> StoreTask(FamilyFarmTask task)
        {
            throw new NotImplementedException();
        }
    }
}
