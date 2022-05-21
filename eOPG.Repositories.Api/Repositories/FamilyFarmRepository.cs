using eOPG.ClassLibrary.Api;
using eOPG.ClassLibrary.Api.Models;
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
        public Task<FamilyFarm> CreateFamilyFarmAsync(string name, string adress, int regionId, int cityId)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task DeleteFamilyFarmAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FamilyFarm> GetFamilyFarm(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<FamilyFarm> UpdateFamilyFarmAsync()
        {
            throw new NotImplementedException();
        }
    }
}
