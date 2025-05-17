using Dal.models;

namespace Server.models
{
    public class LoginResponse
    {
        public Client? Client { get; set; }
        public string? Token { get; set; }
    }
}
