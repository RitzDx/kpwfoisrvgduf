namespace CrypticSource.JsonClasses
{
    public class GameSession
    {
        public ulong GameSessionId { get; set; }
        public string PhotonRegionId { get; set; }
        public string PhotonRoomId { get; set; }
        public string Name { get; set; }
        public ulong RoomId { get; set; }
        public ulong RoomSceneId { get; set; }
        public string RoomSceneLocationId { get; set; }
        public bool IsSandbox { get; set; }
        public string DataBlobName { get; set; } = string.Empty;
        public ulong? PlayerEventId { get; set; }
        public bool Private { get; set; }
        public bool GameInProgress { get; set; }
        public int MaxCapacity { get; set; }
        public bool IsFull { get; set; }
    }
}
