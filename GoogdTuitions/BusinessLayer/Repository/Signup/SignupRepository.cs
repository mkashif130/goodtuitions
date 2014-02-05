using System;
using System.Data;
using System.Globalization;
using DataAccessLayer.Signup;
using System.Data.SqlClient;
using System.Collections.Generic;
using BusinessLayer.DataLinkLayer;
using BusinessLayer.Utils.Password;
using DataAccessLayer.Response;
namespace BusinessLayer.Repository.Signup
{
    public class SignupRepository : IMainRepository<SignupEntity>
    {
        #region Attributes

        private readonly string _conString = string.Empty;
        private const string ProcedureName = "p_signup";

        #endregion

        #region Parameters

        private const string Mod = "@mod";
        private const string UserName = "@user_name";
        private const string FirstName = "@first_name";
        private const string LastName = "@last_name";
        private const string EmailAddress = "@email_address";
        private const string PasswordHash = "@password_hash";
        private const string PasswordSalt = "@password_salt";
        private const string RegistrationDateTime = "@registration_datetime";

        #endregion

        public SignupRepository()
        {
            _conString = DBGateway.ConnectionString;
        }
        public string Save(SignupEntity signup)
        {
            try
            {
                var parms = new SqlParameter[8];
                var salt = Guid.NewGuid().ToString();

                parms[0] = new SqlParameter(Mod,SqlDbType.Int) {Value = 1};

                parms[1] = new SqlParameter(UserName,SqlDbType.NVarChar) {Value = signup.UserName};

                parms[2] = new SqlParameter(FirstName,SqlDbType.NVarChar) {Value = signup.FirstName};

                parms[3]=new SqlParameter(LastName,SqlDbType.NVarChar) {Value = signup.LastName};

                parms[4] = new SqlParameter(EmailAddress,SqlDbType.NVarChar) {Value = signup.EmailAddress};

                parms[5] = new SqlParameter(PasswordHash,SqlDbType.NVarChar) {Value =PasswordGenerator.EncryptPassword(signup.Password,salt)};

                parms[6] = new SqlParameter(PasswordSalt, SqlDbType.NVarChar) { Value = salt };

                parms[7] = new SqlParameter(RegistrationDateTime,SqlDbType.NVarChar){Value=DateTime.Now.ToString(CultureInfo.InvariantCulture)};

                SqlHelper.ExecuteNonQuery(_conString, CommandType.StoredProcedure, ProcedureName,parms);

                return ResponseMessages.Created;
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message,exception);
            }
        }

        public string Update(SignupEntity obj)
        {
            throw new System.NotImplementedException();
        }

        public string Delete(SignupEntity obj)
        {
            throw new System.NotImplementedException();
        }

        public List<SignupEntity> Get()
        {
            throw new System.NotImplementedException();
        }


        public SignupEntity GetSingle<T>(T t)
        {
            throw new NotImplementedException();
        }
    }
}
