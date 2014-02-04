using System;
using System.Data;
using System.Linq;
using DataAccessLayer.Login;
using System.Collections.Generic;
using BusinessLayer.DataLinkLayer;
using System.Data.SqlClient;
namespace BusinessLayer.Repository.Login
{
    public class LoginRepository : IMainRepository<LoginEntity>
    {
        #region Attributes

        private readonly string _conString = string.Empty;
        private const string ProcedureName = "p_login";

        #endregion

        #region Parameters
        public const string ParamMod = "@mod";
        public const string ParamUserId = "@email_address";
        #endregion

        #region Fields

        public const string FieldEmailAddress = "email_address";
        public const string FieldPasswordHash = "password_hash";
        public const string FieldPasswordSalt = "password_salt";
        #endregion

        #region Constructor
        public LoginRepository()
        {
            _conString = DBGateway.ConnectionString;
        }
        #endregion
        public string Save(LoginEntity obj)
        {
            throw new System.NotImplementedException();
        }

        public string Update(LoginEntity obj)
        {
            throw new System.NotImplementedException();
        }

        public string Delete(LoginEntity obj)
        {
            throw new System.NotImplementedException();
        }

        public List<LoginEntity> Get()
        {
            throw new System.NotImplementedException();
        }

        public LoginEntity GetSingle<T>(T t)
        {
            try
            {
                var userId = TConverter.ChangeType<string>(t);

                var parms = new SqlParameter[2];

                parms[0] = new SqlParameter(ParamMod,SqlDbType.Int){Value = 1};

                parms[1] = new SqlParameter(ParamUserId,SqlDbType.NVarChar){Value = userId};

                var dt = SqlHelper.ExecuteTable(_conString, CommandType.StoredProcedure, ProcedureName, parms);

                if (dt!=null && dt.Rows.Count>0)
                {
                    return (from DataRow row in dt.Rows
                            select new LoginEntity
                                       {
                                           EmailAddress = row[FieldEmailAddress].ToString(), PasswordHash = row[FieldPasswordHash].ToString(), PasswordSalt = row[FieldPasswordSalt].ToString()
                                       }
                           ).FirstOrDefault();
                }
                return null;

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
