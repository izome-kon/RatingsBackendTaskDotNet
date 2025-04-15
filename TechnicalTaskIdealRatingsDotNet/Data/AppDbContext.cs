using Microsoft.EntityFrameworkCore;
using TechnicalTaskIdealRatingsDotNet.Models;

namespace TechnicalTaskIdealRatingsDotNet.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}
    
    public DbSet<Person> Persons { get; set; }
}