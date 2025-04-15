using Microsoft.EntityFrameworkCore;
using TechnicalTaskIdealRatingsDotNet.Models;

namespace TechnicalTaskIdealRatingsDotNet.Data
{
    public static class DataSeeder
    {
        public static void SeedInitialData(AppDbContext context)
        {
            if (!context.Persons.Any())
            {
                context.Persons.AddRange(
                    new Person
                    {
                        Name = "Ahmed Mohammed",
                        TelephoneNumber = "20-010334445",
                        Address = "10 Road Street",
                        Country = "Egypt"
                    },
                    new Person
                    {
                        Name = "Mona Mahmoud",
                        TelephoneNumber = "20-010334445",
                        Address = "11 Road Street",
                        Country = "Egypt"
                    },
                    new Person
                    {
                        Name = "Mohammed Rabie",
                        TelephoneNumber = "970-111111111",
                        Address = "15 Road Street",
                        Country = "Palestine"
                    },
                    new Person
                    {
                        Name = "Ana yousif",
                        TelephoneNumber = "961-111111111",
                        Address = "20 Road Street",
                        Country = "Lebanon"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}