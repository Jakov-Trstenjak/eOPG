using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOPG.Services.Api.Services
{
    public interface IFamilyFarmService
    {
        Task<CreateFamilyFarmResult> CreateFamilyFarm(string name, string adress, int regionId, int cityId);
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
