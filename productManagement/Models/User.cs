using System.Text.Json.Serialization;

namespace productManagement.Models
{
    public class User
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        
        [JsonIgnore]
        public string? Token { get; set; }


    }
}
