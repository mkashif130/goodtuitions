namespace DataAccessLayer.User
{
    public class ProfileEntity : UserInfoEntity
    {
        public string CellNo { get; set; }
        public string TelephoneNo { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
    }
}
