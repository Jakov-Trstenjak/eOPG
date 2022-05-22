using eOPG.ClassLibrary.Api;
using eOPG.ClassLibrary.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOPG.Services.Api.Services
{
    public interface IFamilyFarmService
    {
        Task<FamilyFarm> CreateFamilyFarm(string name, string adress, int regionId, int cityId);

        Task<FamilyFarm> GetFamilyFarm(Guid Id);
    
    }

    public class CreateFamilyFarmResult
    {
        public CreateFamilyFarmResultStatus Status { get; set; }
    }

    public enum CreateFamilyFarmResultStatus
    {
        Ok = 1,
        Failed = 2
    }
}
