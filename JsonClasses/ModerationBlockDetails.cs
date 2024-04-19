namespace CrypticSource.JsonClasses
{
    public class ModerationBlockDetails
    {
        public int ReportCategory { get; set; } = 0;
        public int Duration { get; set; } = 0;
        public long GameSessionId { get; set; } = 0L;
        public string? Message { get; set; } = "";
    }
}
