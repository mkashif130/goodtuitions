using System.Net.Http;

namespace BusinessLayer.Response
{
    public class HttpExceptionResponse : HttpResponseMessage
    {
        public HttpExceptionResponse(string message)
        {
            ReasonPhrase = message;
        }
        public static HttpExceptionResponse NetworkError = new HttpExceptionResponse("Network error occur, Please check your connection or contact to network administrator");

        public static HttpExceptionResponse UserNotFound = new HttpExceptionResponse("User not found");
        public static HttpExceptionResponse UserAlreadyExists = new HttpExceptionResponse("User already exists");
        public static HttpExceptionResponse InvalidPassword = new HttpExceptionResponse("Invalid password");
        public static HttpExceptionResponse UnknownError = new HttpExceptionResponse("Unknown Error");
        public static HttpExceptionResponse EmailNotSent = new HttpExceptionResponse("Email sending fail");
        public static HttpExceptionResponse InvalidToken = new HttpExceptionResponse("Invalid Token");
        public static HttpExceptionResponse TokenAlreadyUsed = new HttpExceptionResponse("Token Already Used");
        public static HttpExceptionResponse TokenExpired = new HttpExceptionResponse("Token Expired, Please retry for new token");
        public static HttpExceptionResponse TemplateNotFound= new HttpExceptionResponse("Template not found");
    }
}
