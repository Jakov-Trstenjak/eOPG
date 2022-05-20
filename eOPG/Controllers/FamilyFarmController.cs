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


        public int CreateFamilyFarm(
            string name,
            string adress,
            int regionId,
            int cityId)
        {

            _familyFarmService.CreateFamilyFarm(name, adress, regionId, cityId);

            return 1;
        }
    }
}
