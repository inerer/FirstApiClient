using System.Text.Json.Serialization;

namespace FirstApiClient.Models.Client
{
    public class Client
    {
        [JsonPropertyName("clientId")]
        public int ClientId { get; set; }
        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }
        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }
        [JsonPropertyName("middleName")]
        public string? MiddleName { get; set; }
    }
}