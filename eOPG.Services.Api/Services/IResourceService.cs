using eOPG.ClassLibrary.Api.Enums;
using eOPG.ClassLibrary.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOPG.Services.Api.Services
{
    public interface IResourceService
    {
        Task<Resource> CreateResource(string name, string amount, Guid familyFarmId, ResourceType resourceType, ResourceSubType resourceSubType);

        Task<Resource> GetResource(Guid Id);
    }
}
