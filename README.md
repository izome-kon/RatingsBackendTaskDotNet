## Technologies

- **Backend Framework**: .NET Core
- **Database**: SQL Server
- **API**: RESTful APIs

## Folder Structure

```
BackendDotNet
├─ TechnicalTaskIdealRatingsDotNet
│  ├─ Controllers
│  │  └─ PersonController.cs
│  ├─ DTOs
│  │  └─ PersonDto.cs
│  ├─ Data
│  │  ├─ AppDbContext.cs
│  │  ├─ DataSeeder.cs
│  │  └─ person.csv
│  ├─ Dockerfile
│  ├─ Filters
│  │  └─ PersonFilter.cs
│  ├─ Mappers
│  │  ├─ CSVPersonMap.cs
│  │  └─ PersonMapper.cs
│  ├─ Middlewares
│  │  └─ ErrorHandlingMiddleware.cs
│  ├─ Migrations
│  ├─ Models
│  │  └─ Person.cs
│  ├─ Program.cs
│  ├─ Properties
│  │  └─ launchSettings.json
│  ├─ Repositories
│  │  └─ Person
│  │     ├─ CsvPersonRepository.cs
│  │     ├─ IPersonRepository.cs
│  │     └─ MssqlPersonRepository.cs
│  ├─ Services
│  │  └─ PersonService.cs
│  ├─ TechnicalTaskIdealRatingsDotNet.csproj
│  ├─ appsettings.Development.json
│  ├─ appsettings.json
├─ TechnicalTaskIdealRatingsDotNet.sln
├─ TechnicalTaskIdealRatingsDotNet.sln.DotSettings.user
├─ compose.yaml
└─ global.json
```