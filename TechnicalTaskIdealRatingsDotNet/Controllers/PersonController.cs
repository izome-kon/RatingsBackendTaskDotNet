using Microsoft.AspNetCore.Mvc;
using TechnicalTaskIdealRatingsDotNet.DTOs;
using TechnicalTaskIdealRatingsDotNet.Filters;
using TechnicalTaskIdealRatingsDotNet.Services;

namespace TechnicalTaskIdealRatingsDotNet.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    private readonly PersonService _personService;
    
    public PersonController(PersonService personService)
    {
        _personService = personService;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<PersonDto>>> GetAllPersons([FromQuery] PersonFilter filter)
    {
        var persons = await _personService.GetAllPersonsAsync(filter);
        return Ok(persons);
    }

}