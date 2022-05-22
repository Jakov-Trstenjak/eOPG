using eOPG.ClassLibrary.Api.Models;
using eOPG.Services.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace eOPG.Controllers
{
    [ApiController]
    [Route("person")]
    public class PersonController : Controller
    {
        #region Constructor
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        #endregion


        [HttpGet("getPerson")]
        public async Task<Person> GetPerson(Guid Id)
        {

            var result = await _personService.GetPerson(Id);

            return result;
        }

        [HttpPost("storePerson")]
        public async Task<IActionResult> StorePerson(Person person)
        {

            var result = await _personService.StorePerson(person);

            return Ok(person);
        }




    }
}
