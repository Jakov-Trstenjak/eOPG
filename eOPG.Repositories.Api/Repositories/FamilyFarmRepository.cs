using eOPG.ClassLibrary.Api;
using eOPG.Repositories.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOPG.Repositories.Api.Repositories
{
    internal class FamilyFarmRepository : IFamilyFarmRepository
    {
        public Task<FamilyFarmInfo> CreateFamilyFarmAsync(string name, string adress, int regionId, int cityId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteFamilyFarmAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FamilyFarmInfo> UpdateFamilyFarmAsync()
        {
            throw new NotImplementedException();
        }
    }
}
