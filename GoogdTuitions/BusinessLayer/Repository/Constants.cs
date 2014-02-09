namespace BusinessLayer.Repository
{
    public class Constants
    {
        public Constants(string value)
        {
            Value = value;
        }
        public static Constants Update = new Constants("Update");
        public static Constants Reset = new Constants("Reset");
        public string Value { get; set; }
    }
}
