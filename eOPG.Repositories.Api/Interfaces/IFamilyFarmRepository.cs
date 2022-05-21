using eOPG.ClassLibrary.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOPG.Repositories.Api.Interfaces
{
    public interface IFamilyFarmRepository
    {
        Task<FamilyFarmInfo> CreateFamilyFarmAsync(string name, string adress, int regionId, int cityId);
        Task DeleteFamilyFarmAsync();
        Task<FamilyFarmInfo> UpdateFamilyFarmAsync();
    }
}
