using TechnicalTaskIdealRatingsDotNet.DTOs;
using TechnicalTaskIdealRatingsDotNet.Models;

namespace TechnicalTaskIdealRatingsDotNet.Mappers;

public class PersonMapper
{
    public static PersonResponse ToDto(Person person)
    {
        return new PersonResponse
        {
            FirstName = person.Name?.Split(' ').FirstOrDefault() ?? "",
            LastName = person.Name?.Split(' ').Skip(1).FirstOrDefault() ?? "",
            TelephoneCode = person.TelephoneNumber?.Split('-').FirstOrDefault() ?? "",
            TelephoneNumber = person.TelephoneNumber?.Split('-').Skip(1).FirstOrDefault() ?? "",
            Address = person.Address ?? "",
            Country = person.Country ?? ""
        };
    }
}