using Microsoft.EntityFrameworkCore;
using TechnicalTaskIdealRatingsDotNet.Data;
using TechnicalTaskIdealRatingsDotNet.Middlewares;
using TechnicalTaskIdealRatingsDotNet.Repositories.Person;
using TechnicalTaskIdealRatingsDotNet.Services;
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("http://localhost:5173")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("mssqlConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<CsvPersonRepository>(sp =>
    new CsvPersonRepository(builder.Configuration.GetSection("CsvSettings")["CsvPath"] ?? ""));

builder.Services.AddScoped<MssqlPersonRepository>();

builder.Services.AddScoped<PersonService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(MyAllowSpecificOrigins);
app.UseMiddleware<ErrorHandlingMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();