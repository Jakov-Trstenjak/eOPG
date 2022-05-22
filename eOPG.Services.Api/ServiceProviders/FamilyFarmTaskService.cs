using eOPG.ClassLibrary.Api.Models;
using eOPG.Services.Api.Services;


namespace eOPG.Services.Api.ServiceProviders
{
    public class FamilyFarmTaskService : IFamilyFarmTaskService
    {
        #region Constructor

        private readonly IFamilyFarmTaskService _repository;

        public FamilyFarmTaskService(IFamilyFarmTaskService familyFarmTaskRepository)
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
