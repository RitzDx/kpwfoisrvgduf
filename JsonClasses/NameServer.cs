namespace CrypticSource.JsonClasses
{
    public class NameServer
    {
        public string Auth { get; set; } = "http://localhost:7689";
        public string API { get; set; } = "http://localhost:7689";
        public string WWW { get; set; } = "http://localhost:7689";
        public string Notifications { get; set; } = "ws://localhost:7698";
        public string Images { get; set; } = "http://localhost:7689";
    }
}
