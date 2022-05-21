using eOPG.ClassLibrary.Api.Models;
using eOPG.Services.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace e_OPG.Controllers
{
    public class FamilyFarmController : Controller
    {
        #region Services
        private readonly IFamilyFarmService _familyFarmService;

        public FamilyFarmController(IFamilyFarmService familyFarmService)
        {
            _familyFarmService = familyFarmService;
        }

        #endregion

        [HttpPut(Name = "CreateFamilyFarm")]
        public async Task<FamilyFarm> CreateFamilyFarm(
            string name,
            string adress,
            int regionId,
            int cityId)
        {
            
            var result = await _familyFarmService.CreateFamilyFarm(name, adress, regionId, cityId);

            return result;
        }

        [HttpPut(Name = "GetFamilyFarm")]
        public async Task<FamilyFarm> GetFamilyFarm(Guid Id)
        {

            var result = await _familyFarmService.GetFamilyFarm(Id);

            return result;
        }
    }
}
