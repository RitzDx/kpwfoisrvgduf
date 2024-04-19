using WebSocketSharp;
using WebSocketSharp.Server;
using Newtonsoft.Json;
using static CrypticSource.Controllers.ApiController;
using CrypticSource.JsonClasses;

namespace CrypticSource.WebSocket
{
    public class WebSocket
    {
        public WebSocket() 
        {
            WebSocketServer webSocketServer = new WebSocketServer("ws://localhost:7698");
            webSocketServer.AddWebSocketService<Notification>("/api/notification/v2");
            webSocketServer.Start();
        }

        public class Notification : WebSocketBehavior
        {
            protected override void OnMessage(MessageEventArgs e)
            {
                base.Send(JsonConvert.SerializeObject(new
				{
					Id = 12,
					Msg = Presence.GetPresence(UserIds[Context.UserEndPoint.Address.ToString()])
				}));
            }
        }

        public class Presence
        {
            public static Presence GetPresence(ulong userid)
            {
				return new Presence
				{
					PlayerId = userid,
					IsOnline = true,
					PlayerType = PlayerType.SCREEN, //you can leave this as screen even if you are in vr 
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
					}
				};
			}

            public ulong PlayerId { get; set; }
            public bool IsOnline { get; set; }
            public PlayerType PlayerType { get; set; } 
            public GameSession GameSession { get; set; }
        }

		public enum PlayerType
		{
			UNINITIALIZED,
			VR_WALK,
			VR_TELEPORT,
			SCREEN
		}
	}
}
