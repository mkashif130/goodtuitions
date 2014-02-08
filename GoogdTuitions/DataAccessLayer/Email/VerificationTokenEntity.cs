using System;
namespace DataAccessLayer.Email
{
    public class VerificationTokenEntity
    {
        public string EmailAddress { get; set; }
        public string Token { get; set; }
        public string TokenPurpose { get; set; }
        public bool IsConsumed { get; set; }
        public DateTime CreatedTimestamp { get; set; }
        public int ExpiryTime { get; set; }
    }
}
