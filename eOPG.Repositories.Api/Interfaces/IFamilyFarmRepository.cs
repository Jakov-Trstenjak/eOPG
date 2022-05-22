using eOPG.ClassLibrary.Api;
using eOPG.ClassLibrary.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOPG.Repositories.Api.Interfaces
{
    public interface IFamilyFarmRepository
    {
        Task<FamilyFarm> CreateFamilyFarmAsync(string name, string adress, int regionId, int cityId);
        System.Threading.Tasks.Task DeleteFamilyFarmAsync();
        Task<FamilyFarm> UpdateFamilyFarmAsync();
        Task<FamilyFarm> GetFamilyFarm(Guid Id);
    }
}
