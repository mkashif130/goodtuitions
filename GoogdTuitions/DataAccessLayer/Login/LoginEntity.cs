namespace DataAccessLayer.Login
{
    public class LoginEntity
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }        
    }
}
