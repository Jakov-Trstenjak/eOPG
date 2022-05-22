using eOPG.ClassLibrary.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOPG.Services.Api.Services
{
    public interface IPersonService
    {
        Task<Person> StorePerson(Person person);

        Task<Person> GetPerson(Guid Id);
    }
}
