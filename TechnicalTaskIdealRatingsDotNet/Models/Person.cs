using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechnicalTaskIdealRatingsDotNet.Models;

[Table("Person_Details")]
public class Person
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    public string? Name { get; set; }
    [Column("telephone Number")]
    public string? TelephoneNumber { get; set; }

    [Column("address")]
    public string? Address { get; set; }

    [Column("country")]
    public string? Country { get; set; }
}