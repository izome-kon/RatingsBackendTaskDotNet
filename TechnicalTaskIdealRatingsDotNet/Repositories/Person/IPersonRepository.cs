
using TechnicalTaskIdealRatingsDotNet.DTOs;
using TechnicalTaskIdealRatingsDotNet.Filters;

namespace TechnicalTaskIdealRatingsDotNet.Repositories.Person;

public interface IPersonRepository
{ 
    Task<List<PersonResponse>> GetAllPersonsAsync(PersonFilter? filter = null);
}