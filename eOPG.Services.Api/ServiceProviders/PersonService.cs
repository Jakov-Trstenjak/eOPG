using eOPG.ClassLibrary.Api.Models;
using eOPG.Services.Api.Services;
using eOPG.Repositories.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eOPG.Services.Api.ServiceProviders
{
    public class PersonService : IPersonService
    {
        #region Constructor

        private readonly IPersonRepository _repository;

        public PersonService(IPersonRepository personRepository)
        {
            _repository = personRepository;
        }

        #endregion


        public Task<Person> GetPerson(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<Person> StorePerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
