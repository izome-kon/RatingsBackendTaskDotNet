using System.Text.Json.Serialization;

namespace TechnicalTaskIdealRatingsDotNet.DTOs;

public class PersonDto
{
    [JsonPropertyName("first name")]
    public string FirstName { get; set; } = string.Empty;
    [JsonPropertyName("last name")]
    public string LastName { get; set; } = string.Empty;
    [JsonPropertyName("telephone code")]
    public string TelephoneCode { get; set; } = string.Empty;
    [JsonPropertyName("telephone number")]
    public string TelephoneNumber { get; set; } = string.Empty;
    [JsonPropertyName("address")]
    public string Address { get; set; } = string.Empty;
    [JsonPropertyName("country")]
    public string Country { get; set; } = string.Empty;
}