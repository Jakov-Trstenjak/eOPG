using eOPG.ClassLibrary.Api;
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

        private readonly IFamilyFarmRepository _familyFarmRepository;

        public FamilyFarmService(IFamilyFarmRepository familyFarmRepository)
        {
            _familyFarmRepository = familyFarmRepository;
        }

        #endregion


        public async Task<FamilyFarmInfo> CreateFamilyFarm(string name, string adress, int regionId, int cityId)
        {
            return await _familyFarmRepository.CreateFamilyFarmAsync(name, adress, regionId, cityId);
        }
    }
}
