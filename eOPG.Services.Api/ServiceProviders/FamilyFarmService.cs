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
        public Task<CreateFamilyFarmResult> CreateFamilyFarm(string name, string adress, int regionId, int cityId)
        {
            throw new NotImplementedException();
        }
    }
}
