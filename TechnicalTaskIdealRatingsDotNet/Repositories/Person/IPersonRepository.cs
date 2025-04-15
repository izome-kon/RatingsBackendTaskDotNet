
using TechnicalTaskIdealRatingsDotNet.DTOs;
using TechnicalTaskIdealRatingsDotNet.Filters;

namespace TechnicalTaskIdealRatingsDotNet.Repositories.Person;

public interface IPersonRepository
{ 
    Task<List<PersonDto>> GetAllPersonsAsync(PersonFilter? filter = null);
}