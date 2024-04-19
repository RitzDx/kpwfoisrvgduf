namespace CrypticSource.JsonClasses
{
    public class LoginCachedRequest
    {
        public string AppVersion { get; set; }
        public int Platform { get; set; }
        public string PlatformId { get; set; }
        public long ClientTimestamp { get; set; }
        public long BuildTimestamp { get; set; }
        public string DeviceId { get; set; }
        public string LoginLockToken { get; set; }
        public string AuthParams { get; set; }
        public string Verify { get; set; }
        public ulong PlayerId { get; set; }
    }
}
