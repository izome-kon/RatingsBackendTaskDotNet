using CsvHelper.Configuration;
using TechnicalTaskIdealRatingsDotNet.DTOs;


namespace TechnicalTaskIdealRatingsDotNet.Mappers;

public class PersonResponseMap : ClassMap<PersonResponse>
{
    public PersonResponseMap()
    {
        Map(m => m.FirstName).Name("First Name");
        Map(m => m.LastName).Name("Last Name");
        Map(m => m.TelephoneCode).Name("Country code");
        Map(m => m.TelephoneNumber).Name("Number");
        Map(m => m.Address).Name("Full Address");
        Map(m => m.Country).Name("Country");
    }
}