using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using BusinessLayer.DataLinkLayer;
using DataAccessLayer.User;

namespace BusinessLayer.Repository.User
{
    public class ProfileRepository : IMainRepository<ProfileEntity>
    {
        #region Attributes

        private readonly string _conString = string.Empty;
        private const string ProcedureName = "p_profile";

        #endregion

        #region Params

        public const string ParamMod = "@mod";
        public const string ParamUserId = "@email_address";
        #endregion

        #region Fields

        public const string FieldFirstName = "first_name";
        public const string FieldLastName = "last_name";
        public const string FieldUserName = "user_name";
        public const string FieldRegisterDateTime = "registration_datetime";
        public const string FieldCellNo = "cell_number";
        public const string FieldTelephoneNo = "telephone_number";
        public const string FieldEmailAddress = "email_address";
        public const string FieldAddress = "address";
        public const string FieldCountry = "country";
        public const string FieldProvince = "province";
        public const string FieldCity = "city";
        #endregion

        #region Consructor
        public ProfileRepository()
        {
            _conString = DBGateway.ConnectionString;
        }
        #endregion
        public string Save(ProfileEntity obj)
        {
            throw new System.NotImplementedException();
        }

        public string Update(ProfileEntity obj)
        {
            throw new System.NotImplementedException();
        }

        public string Delete(ProfileEntity obj)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<ProfileEntity> Get()
        {
            throw new System.NotImplementedException();
        }

        public ProfileEntity GetSingle<T>(T t)
        {
            try
            {
                var userId = TConverter.ChangeType<string>(t);

                var parms = new SqlParameter[2];

                parms[0] = new SqlParameter(ParamMod, SqlDbType.Int) { Value = 1 };

                parms[1] = new SqlParameter(ParamUserId, SqlDbType.NVarChar) { Value = userId };

                var dt = SqlHelper.ExecuteTable(_conString, CommandType.StoredProcedure, ProcedureName, parms);

                if (dt != null && dt.Rows.Count > 0)
                {
                    return (from DataRow row in dt.Rows
                            select new ProfileEntity
                                       {
                                           FirstName = row[FieldFirstName].ToString(), LastName = row[FieldLastName].ToString(), UserName = row[FieldUserName].ToString(), RegistrationDateTime = row[FieldRegisterDateTime].ToString(), CellNo = row[FieldCellNo].ToString(), TelephoneNo = row[FieldTelephoneNo].ToString(), EmailAddress = row[FieldEmailAddress].ToString(), Address = row[FieldAddress].ToString(), Country = row[FieldCountry].ToString(), Province = row[FieldProvince].ToString(), City = row[FieldCity].ToString()
                                       }).FirstOrDefault();
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
