namespace DataAccessLayer.User
{
    public class ChangePasswordEntity
    {
        public string EmailAdderss { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
