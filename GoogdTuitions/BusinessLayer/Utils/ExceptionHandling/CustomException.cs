using DataAccessLayer.Response;
using System;
using System.Data.SqlClient;

namespace BusinessLayer.Utils.ExceptionHandling
{
    public class CustomException
    {
        public static string CreateException(Exception exception)
        {
            if (exception is SqlException)
            {
                var sqlException = (SqlException)exception;
                if (sqlException.Number == 2627)
                {
                    return ResponseMessages.AlreadyExist;
                }
                if (sqlException.Number==-1)
                {
                    return ResponseMessages.NetworkError;
                }
            }
            else
            {
                throw exception;
            }
            return ResponseMessages.Exception;
        }
    }
}
