using System;
using System.Data;
using System.Data.SqlClient;
using BusinessLayer.DataLinkLayer;
using BusinessLayer.Utils.ExceptionHandling;
using BusinessLayer.Utils.Password;
using DataAccessLayer.Response;
using DataAccessLayer.User;

namespace BusinessLayer.Repository.User
{
    public class ChangePasswordRepository : IMainRepository<ChangePasswordEntity>
    {
        #region Attributes

        private readonly string _conString = string.Empty;
        private const string ProcedureName = "p_change_password";

        #endregion

        #region Parameters

        private const string Mod = "@mod";
        private const string EmailAddress = "@email_address";
        private const string PasswordHash = "@password_hash";
        private const string PasswordSalt = "@password_salt";
        private const string ChangeType = "@change_type";
        #endregion
        public ChangePasswordRepository()
        {
            _conString = DBGateway.ConnectionString;
        }
        public string Save(ChangePasswordEntity obj)
        {
            throw new System.NotImplementedException();
        }

        public string Update(ChangePasswordEntity obj)
        {
            throw new System.NotImplementedException();
        }

        public string Delete(ChangePasswordEntity obj)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<ChangePasswordEntity> Get()
        {
            throw new System.NotImplementedException();
        }

        public ChangePasswordEntity GetSingle<T>(T t)
        {
            throw new System.NotImplementedException();
        }
        public string UpdatePassword(string password, string emailAddress, Constants changeType)
        {
            try
            {
                var parms = new SqlParameter[5];

                var salt = Guid.NewGuid().ToString();

                parms[0] = new SqlParameter(Mod, SqlDbType.Int) { Value = 1 };

                parms[1] = new SqlParameter(PasswordHash, SqlDbType.NVarChar) { Value = PasswordGenerator.EncryptPassword(password, salt) };

                parms[2] = new SqlParameter(PasswordSalt, SqlDbType.NVarChar) { Value = salt };

                parms[3] = new SqlParameter(EmailAddress, SqlDbType.NVarChar) { Value = emailAddress };

                parms[4] = new SqlParameter(ChangeType, SqlDbType.NChar) { Value = changeType.Value };

                SqlHelper.ExecuteNonQuery(_conString, CommandType.StoredProcedure, ProcedureName, parms);

                return ResponseMessages.Updated;
            }
            catch (Exception exception)
            {
                return CustomException.CreateException(exception);
            }
        }
    }
}
