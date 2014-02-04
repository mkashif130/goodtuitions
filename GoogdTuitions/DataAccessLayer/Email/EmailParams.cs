using System;
using System.Collections.Generic;

namespace DataAccessLayer.Email
{
    /// <summary>
    /// This class will set email parameters
    /// <Author>Muhammad Arslan</Author>
    /// <Dated>08-May-2013</Dated>
    /// </summary>
    public abstract class EmailParams
    {
        #region Attributes
        Dictionary<String, String> _emailParms;
        #endregion

        #region Methods/Functions
        /// <summary>
        /// This method will set parameters of email
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        protected void SetParameter(String key, String value)
        {
            if (_emailParms==null)
            {
                _emailParms = new Dictionary<String, String>(); 
            }
            _emailParms.Add(key, value);
        }
        #endregion

        #region Properties
        /// <summary>
        /// This property will return email parameter dictionary
        /// </summary>
        /// <returns></returns>
        public Dictionary<String, String> GetEmailParameters()
        {
            return _emailParms;
        }
        #endregion
    }
}
