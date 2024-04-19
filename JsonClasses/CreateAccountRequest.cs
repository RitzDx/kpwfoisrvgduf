namespace CrypticSource.JsonClasses
{
    public class CreateAccountRequest
    {
        public string AppVersion { get; set; } = string.Empty;
        public int Platform { get; set; }
        public string PlatformId { get; set; } = string.Empty;
        public long ClientTimestamp { get; set; }
        public long BuildTimestamp { get; set; }
        public string DeviceId { get; set; } = string.Empty;
        public string LoginLockToken { get; set; } = string.Empty;
        public string AuthParams { get; set; } = string.Empty;
        public string Verify { get; set; } = string.Empty;
    }
}
