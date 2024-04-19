namespace CrypticSource.JsonClasses
{
    public class Profile
    {
        // the = stuff is so you don't get warnings
        public ulong Id { get; set; }
        public string Username { get; set; } = string.Empty; 
        public string DisplayName { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
        public int XP { get; set; }
        public int Level { get; set; }
        public int RegistrationStatus { get; set; }
        public bool Developer { get; set; }
        public bool CanReceiveInvites { get; set; }
        public string ProfileImageName { get; set; } = string.Empty;
        public bool JuniorProfile { get; set; }
        public bool ForceJuniorImages { get; set; }
        public bool PendingJunior { get; set; }
        public bool HasBirthday { get; set; }
        public bool AvoidJuniors { get; set; }
        public PlayerReputation PlayerReputation { get; set; } = new PlayerReputation();
        public PlatformIds PlatformId { get; set; } = new PlatformIds();
    }
}
