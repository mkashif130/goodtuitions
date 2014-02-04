using System;

namespace DataAccessLayer.Email
{
    public class SubscriptionParams : EmailParams
    {
        #region Constructors
        // Default Constructor
        public SubscriptionParams()
        {
        }
        public SubscriptionParams(String emailId)
        {
            SetParameter("###EmailId###", emailId);
        }
        #endregion
    }
}
