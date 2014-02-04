using System;

namespace DataAccessLayer.Email
{
    /// <summary>
    /// This class will set parameters of signup email
    /// <Author>Muhammad Arslan</Author>
    /// <Dated>08-May-2013</Dated>
    /// </summary>
    public class SignupEmailParms:EmailParams
    {
        #region Constructors
        // Default Constructor
        public SignupEmailParms()
        {
        }
        public SignupEmailParms(String name, String userId, String password, String verifyLink)
        {
            SetParameter("###Name###", name);
            SetParameter("###UserId###", userId);
            SetParameter("###Password###", password);
            SetParameter("###VerifyLink####", verifyLink);
        }
        #endregion
    }
}
