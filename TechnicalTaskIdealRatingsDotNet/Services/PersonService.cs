using TechnicalTaskIdealRatingsDotNet.DTOs;
using TechnicalTaskIdealRatingsDotNet.Filters;
using TechnicalTaskIdealRatingsDotNet.Models;
using TechnicalTaskIdealRatingsDotNet.Repositories.Person;

namespace TechnicalTaskIdealRatingsDotNet.Services;

public class PersonService
{
    private readonly CsvPersonRepository _csvRepo;
    private readonly MssqlPersonRepository _mssqlRepo;
    
    public PersonService(CsvPersonRepository csvRepo, MssqlPersonRepository mssqlRepo)
    {
        _csvRepo = csvRepo;
        _mssqlRepo = mssqlRepo;
    }

    public async Task<List<PersonDto>> GetAllPersonsAsync(PersonFilter? filter = null)
    {
        var csvPersonsTask = _csvRepo.GetAllPersonsAsync(filter);
        var dbPersonsTask = _mssqlRepo.GetAllPersonsAsync(filter);

        await Task.WhenAll(csvPersonsTask, dbPersonsTask);

        var allPersons = csvPersonsTask.Result.Concat(dbPersonsTask.Result).ToList();
        return allPersons;
    }
    
}