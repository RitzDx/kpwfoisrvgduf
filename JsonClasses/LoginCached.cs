namespace CrypticSource.JsonClasses
{
    public class LoginCached
    {
        public string? Error { get; set; }
        public Profile Player { get; set; }
        public string? Token { get; set; }
        public bool FirstLoginOfTheDay { get; set; }
        public long AnalyticsSessionId { get; set; }
    }
}
