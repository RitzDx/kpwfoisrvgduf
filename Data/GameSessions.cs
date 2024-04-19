using CrypticSource.JsonClasses;
using Newtonsoft.Json;

namespace CrypticSource.Data
{
    public class GameSessions
    {
        public static string JoinRoom(ulong userid)
        {
            // this part i was very lazy at lmao
            return JsonConvert.SerializeObject(new
            {
                Result = 0,
                GameSession = new GameSession
                {
                    GameSessionId = 5555,
                    PhotonRegionId = "us",
                    PhotonRoomId = "DormRoom",
                    Name = "DormRoom",
                    RoomId = 1,
                    RoomSceneId = 1,
                    RoomSceneLocationId = "76d98498-60a1-430c-ab76-b54a29b7a163",
                    IsSandbox = false,
                    DataBlobName = "",
                    PlayerEventId = null,
                    Private = true,
                    GameInProgress = false,
                    MaxCapacity = 4,
                    IsFull = false
                },
                RoomDetails = JsonConvert.DeserializeObject<object>(File.ReadAllText(Environment.CurrentDirectory + $"/Data/DormRoom.json"))
            });
        }
    }
}
