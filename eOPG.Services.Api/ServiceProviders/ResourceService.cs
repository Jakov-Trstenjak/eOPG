using eOPG.ClassLibrary.Api.Enums;
using eOPG.ClassLibrary.Api.Models;
using eOPG.Repositories.Api.Interfaces;
using eOPG.Services.Api.Services;

namespace eOPG.Services.Api.ServiceProviders
{
    public class ResourceService : IResourceService
    {
        #region Constructor

        private readonly IResourceRepository _repository;

        public ResourceService(IResourceRepository resourceRepository)
        {
            _repository = resourceRepository;
        }

        #endregion


        public Task<Resource> CreateResource(string name, string amount, Guid familyFarmId, ResourceType resourceType, ResourceSubType resourceSubType)
        {
            throw new NotImplementedException();
        }

        public Task<Resource> GetResource(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
