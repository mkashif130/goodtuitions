namespace DataAccessLayer.Response
{
    public class ResponseMessages   
    {
        public const string Created = "Created";
        public const string Error = "Error";
        public const string Exception = "Exception";
        public const string Success = "Success";

        public string Message { get; set; }
        public int Code { get; set; }
    }
}