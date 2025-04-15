using Microsoft.EntityFrameworkCore;
using TechnicalTaskIdealRatingsDotNet.Data;
using TechnicalTaskIdealRatingsDotNet.DTOs;
using TechnicalTaskIdealRatingsDotNet.Filters;
using TechnicalTaskIdealRatingsDotNet.Mappers;

namespace TechnicalTaskIdealRatingsDotNet.Repositories.Person;

public class MssqlPersonRepository: IPersonRepository
{
    
    private readonly AppDbContext _context;

    public MssqlPersonRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<PersonResponse>> GetAllPersonsAsync(PersonFilter? filter = null)
    {
        IQueryable<Models.Person> query = _context.Persons;

        if (filter != null)
        {
            foreach (var filterProp in typeof(PersonFilter).GetProperties())
            {
                var filterValue = filterProp.GetValue(filter) as string;
                if (string.IsNullOrWhiteSpace(filterValue)) continue;

                var entityProp = typeof(Models.Person).GetProperty(filterProp.Name);
                if (entityProp == null || entityProp.PropertyType != typeof(string)) continue;
                
                query = query.Where(p =>
                    EF.Property<string>(p, filterProp.Name)
                        .ToLower().Contains(filterValue.ToLower()));
            }
        }

        var persons = await query.ToListAsync();
        return persons.Select(PersonMapper.ToDto).ToList();
    }
}