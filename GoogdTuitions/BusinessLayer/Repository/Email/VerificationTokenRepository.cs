using System;
using System.Data;
using System.Linq;
using BusinessLayer.DataLinkLayer;
using BusinessLayer.Utils.ExceptionHandling;
using BusinessLayer.Utils.Password;
using DataAccessLayer.Email;
using System.Data.SqlClient;
using DataAccessLayer.Response;

namespace BusinessLayer.Repository.Email
{
    public class VerificationTokenRepository:IMainRepository<VerificationTokenEntity>
    {
        #region Attributes

        private readonly string _conString = string.Empty;
        private const string ProcedureName = "p_verification_token";

        #endregion

        #region Parameters

        private const string Mod = "@mod";
        private const string EmailAddress = "@email_address";
        private const string TokenPurpose = "@token_purpose";
        private const string Token = "@token";
        private const string IsConsumed = "@is_consumed";
        private const string CreatedTimestamp = "@created_timestamp";
        private const string ExpiryDuration = "@expiry_duration";
        private const string PasswordHash = "@password_hash";
        private const string PasswordSalt = "@password_salt";
        #endregion

        #region Fields

        private const string FieldEmailAddress = "email_address";
        private const string FieldTokenPurpose = "token_purpose";
        private const string FieldToken = "token";
        private const string FieldIsConsumed = "is_consumed";
        private const string FieldCreatedTimestamp = "created_timestamp";
        private const string FieldExpiryDuration = "expiry_duration";
        #endregion
        public VerificationTokenRepository()
        {
            _conString = DBGateway.ConnectionString;
        }

        public string Save(VerificationTokenEntity obj)
        {
            try
            {
            var parms = new SqlParameter[7];
            
            parms[0] = new SqlParameter(Mod,SqlDbType.Int){Value = 1};

            parms[1] =new SqlParameter(EmailAddress,SqlDbType.NChar){Value = obj.EmailAddress};

            parms[2] = new SqlParameter(TokenPurpose,SqlDbType.NChar){Value = obj.TokenPurpose};

            parms[3]=new SqlParameter(Token,SqlDbType.NChar){Value=obj.Token};

            parms[4] = new SqlParameter(IsConsumed, SqlDbType.Bit) { Value = obj.IsConsumed };

            parms[5] = new SqlParameter(CreatedTimestamp,SqlDbType.DateTime){Value = DateTime.Now};

            parms[6] = new SqlParameter(ExpiryDuration,SqlDbType.Int){Value = obj.ExpiryTime};

            SqlHelper.ExecuteNonQuery(_conString, CommandType.StoredProcedure, ProcedureName,parms);

            return ResponseMessages.Created;
            }
            catch (Exception exception)
            {
                return CustomException.CreateException(exception);
            }
        }

        public string Update(VerificationTokenEntity obj)
        {
            throw new System.NotImplementedException();
        }

        public string Delete(VerificationTokenEntity obj)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<VerificationTokenEntity> Get()
        {
            throw new System.NotImplementedException();
        }

        public VerificationTokenEntity GetSingle<T>(T t)
        {
            try
            {
                var token = TConverter.ChangeType<string>(t);
                var parms = new SqlParameter[2];

                parms[0] = new SqlParameter(Mod, SqlDbType.Int) {Value = 2};

                parms[1] = new SqlParameter(Token, SqlDbType.NVarChar) {Value = token};

                var dt = SqlHelper.ExecuteTable(_conString, CommandType.StoredProcedure, ProcedureName, parms);

                if (dt != null && dt.Rows.Count > 0)
                {
                    return (from DataRow row in dt.Rows
                            select new VerificationTokenEntity
                                       {
                                           EmailAddress = row[FieldEmailAddress].ToString(),
                                           TokenPurpose = row[FieldTokenPurpose].ToString(),
                                           Token = row[FieldToken].ToString(),
                                           IsConsumed = (bool) row[FieldIsConsumed],
                                           CreatedTimestamp = (DateTime) row[FieldCreatedTimestamp],
                                           ExpiryTime = Convert.ToInt32(row[FieldExpiryDuration])
                                       }).FirstOrDefault();
                }
                return null;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message,exception);
            }
        }

        public string ResetPassword(string password,string emailAddress)
        {
            try
            {
                var parms = new SqlParameter[4];

                var salt = Guid.NewGuid().ToString();

                parms[0] = new SqlParameter(Mod,SqlDbType.Int){Value = 3};

                parms[1] = new SqlParameter(PasswordHash, SqlDbType.NVarChar) { Value = PasswordGenerator.EncryptPassword(password, salt) };

                parms[2] = new SqlParameter(PasswordSalt, SqlDbType.NVarChar) { Value = salt };

                parms[3]= new SqlParameter(EmailAddress,SqlDbType.NVarChar){Value = emailAddress};

                SqlHelper.ExecuteNonQuery(_conString, CommandType.StoredProcedure, ProcedureName,parms);

                return ResponseMessages.Updated;
            }
            catch (Exception exception)
            {
                return CustomException.CreateException(exception);
            }
        }
    }
}
