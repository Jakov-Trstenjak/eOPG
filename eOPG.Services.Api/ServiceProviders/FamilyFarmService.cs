using eOPG.ClassLibrary.Api;
using eOPG.ClassLibrary.Api.Models;
using eOPG.Repositories.Api.Interfaces;
using eOPG.Services.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOPG.Services.Api.ServiceProviders
{
    public class FamilyFarmService : IFamilyFarmService
    {
        #region Constructor

        private readonly IFamilyFarmRepository _repository;

        public FamilyFarmService(IFamilyFarmRepository familyFarmRepository)
        {
            _repository = familyFarmRepository;
        }

        public Task<FamilyFarm> GetFamilyFarm(Guid Id)
        {
            throw new NotImplementedException();
        }

        #endregion


        async Task<FamilyFarm> IFamilyFarmService.CreateFamilyFarm(string name, string adress, int regionId, int cityId)
        {
            return await _repository.CreateFamilyFarmAsync(name, adress, regionId, cityId);      
        }
    }
}
