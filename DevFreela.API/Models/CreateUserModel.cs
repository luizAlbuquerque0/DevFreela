namespace DevFreela.API.Models
{
    public class CreateUserModel
    {
        public string Username { get; private set; }
        public string  Password { get; private set; }
        public string Email { get; private set; }
    }
}
