using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    private PersonService _personService;

    public PersonController(PersonService personService)
    {
        _personService = personService; 
    }
    [HttpPost]
    public async Task<ActionResult<Person>> ajouterPersonne([FromBody] Person person)
    {
        var personneCree = await _personService.ajouterPersonneAsync(person);
        return personneCree; 
    }
}