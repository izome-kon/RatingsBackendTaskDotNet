using System.Globalization;
using CsvHelper;
using System.Linq;
using CsvHelper.Configuration;
using TechnicalTaskIdealRatingsDotNet.DTOs;
using TechnicalTaskIdealRatingsDotNet.Filters;
using TechnicalTaskIdealRatingsDotNet.Mappers;

namespace TechnicalTaskIdealRatingsDotNet.Repositories.Person;

public class CsvPersonRepository : IPersonRepository
{
    private readonly string _csvFilePath;

    public CsvPersonRepository(string csvFilePath)
    {
        _csvFilePath = csvFilePath;
    }

    public async Task<List<PersonDto>> GetAllPersonsAsync(PersonFilter? filter = null)
    {
        var persons = new List<PersonDto>();
        try
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HeaderValidated = null,
                MissingFieldFound = null
            };

            using (var reader = new StreamReader(_csvFilePath))
            using (var csv = new CsvReader(reader, config))
            {
                csv.Context.RegisterClassMap<PersonResponseMap>();

                var records = csv.GetRecordsAsync<PersonDto>()
                    .Where(r => ApplyFilter(r, filter))
                    .ToBlockingEnumerable();

                persons.AddRange(records);
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"File not found: {ex.Message}");
        }
        catch (CsvHelperException ex)
        {
            Console.WriteLine($"CSV Parsing Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }

        return persons;
    }
    
    private bool ApplyFilter(PersonDto person, PersonFilter? filter)
    {
        if (filter == null)
            return true;
        
        if (!string.IsNullOrEmpty(person.Address))
        {
            var addressParts = person.Address.Split(',');
            person.Address = addressParts.FirstOrDefault()?.Trim() ?? string.Empty;
            person.Country = addressParts.Skip(1).FirstOrDefault()?.Trim() ?? string.Empty;
        }
        
        if (!string.IsNullOrWhiteSpace(filter.Name))
        {
            var name = filter.Name.ToLower(); 
            var fullName = $"{person.FirstName} {person.LastName}".ToLower();
            if (!fullName.Contains(name))
                return false;
        }
        
        if (!string.IsNullOrWhiteSpace(filter.Country) && !person.Country.Contains(filter.Country, StringComparison.OrdinalIgnoreCase))
            return false;

        return true;
    }
   
}