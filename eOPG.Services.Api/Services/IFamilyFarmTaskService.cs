using eOPG.ClassLibrary.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOPG.Services.Api.Services
{
    public interface IFamilyFarmTaskService
    {
        Task<FamilyFarmTask> GetTask(Guid familyFarmTaskId);
        Task<List<FamilyFarmTask>> GetTasks(Guid personId);
        Task<FamilyFarmTask> StoreTask(FamilyFarmTask task);    
    }
}