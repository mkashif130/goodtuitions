namespace DataAccessLayer.Email
{
    public class ForgotPasswordParams:EmailParams
    {
        public ForgotPasswordParams(VerificationTokenEntity verificationToken)
        {
            SetParameter("###EmailId###",verificationToken.EmailAddress);
            SetParameter("###Token###",verificationToken.Token);
        }
    }
}
