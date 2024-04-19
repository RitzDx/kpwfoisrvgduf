using CrypticSource.Data;
using CrypticSource.JsonClasses;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Specialized;
using System.Web;
using static CrypticSource.WebSocket.WebSocket;

namespace CrypticSource.Controllers
{
    /* this is the main api controller you can make a new Route by doing something like this: 
        [Route("/nameserver")]
        public string NameServer()
        {
          return "";
        }
    */
    public class ApiController : Controller
    {
        [Route("/nameserver")]
        public string NameServer()
        {
            Console.WriteLine(JsonConvert.SerializeObject(JsonConvert.DeserializeObject<object>(System.IO.File.ReadAllText(Environment.CurrentDirectory + $"/Data/DormRoom.json"))));
            return JsonConvert.SerializeObject(new NameServer());//you can only do this if the values are set in the class
        }

        [Route("/api/versioncheck/v3")]
        public string VersionCheck()
        {
            return JsonConvert.SerializeObject(new VersionCheck());//you can only do this if the values are set in the class
        }

        [Route("/api/config/v2")]
        public string ConfigV2()
        {
            return JsonConvert.SerializeObject(new ConfigV2());//you can only do this if the values are set in the class
        }

        [Route("/api/gameconfigs/v1/all")]
        public string AllGameConfigs()
        {
            return "[{\"Key\":\"Gift.MaxDaily\",\"Value\":\"100\",\"StartTime\":null,\"EndTime\":null},{\"Key\":\"Gift.Falloff\",\"Value\":\"1\",\"StartTime\":null,\"EndTime\":null},{\"Key\":\"Gift.DropChance\",\"Value\":\"100\",\"StartTime\":null,\"EndTime\":null},{\"Key\":\"UseHeartbeatWebSocket\",\"Value\":\"0\",\"StartTime\":null,\"EndTime\":null},,{\"Key\":\"Screens.ForceVerification\",\"Value\":\"0\",\"StartTime\":null,\"EndTime\":null},{\"Key\":\"forceRegistration\",\"Value\":\"0\",\"StartTime\":null,\"EndTime\":null},{\"Key\":\"Door.Creative.Query\",\"Value\":\"#puzzle\",\"StartTime\":null,\"EndTime\":null},{\"Key\":\"Door.Creative.Title\",\"Value\":\"PUZZLE\",\"StartTime\":null,\"EndTime\":null},{\"Key\":\"Door.Featured.Query\",\"Value\":\"#featured\",\"StartTime\":null,\"EndTime\":null},{\"Key\":\"Door.Featured.Title\",\"Value\":\"Featured\",\"StartTime\":null,\"EndTime\":null},{\"Key\":\"Door.Quests.Query\",\"Value\":\"#quest\",\"StartTime\":null,\"EndTime\":null},{\"Key\":\"Door.Quests.Title\",\"Value\":\"QUESTS\",\"StartTime\":null,\"EndTime\":null},{\"Key\":\"Door.Shooters.Query\",\"Value\":\"#pvp #rro\",\"StartTime\":null,\"EndTime\":null},{\"Key\":\"Door.Shooters.Title\",\"Value\":\"PVP\",\"StartTime\":null,\"EndTime\":null},{\"Key\":\"Door.Sports.Query\",\"Value\":\"#sport\",\"StartTime\":null,\"EndTime\":null},{\"Key\":\"Door.Sports.Title\",\"Value\":\"SPORTS & PVP\",\"StartTime\":null,\"EndTime\":null}]";
        }

        [Route("/api/platformlogin/v1/getcachedlogins")]
        public string GetCachedLogins()
        {
            NameValueCollection responseValues = HttpUtility.ParseQueryString(new StreamReader(HttpContext.Request.Body).ReadToEndAsync().Result);
            UserIds.TryAdd(HttpContext.Connection.RemoteIpAddress.ToString(), Convert.ToUInt32(responseValues.Get("PlatformId").Remove(0, 10)));
            return Login.GetCachedLogins(UserIds[HttpContext.Connection.RemoteIpAddress.ToString()]);
        }

        [Route("/api/platformlogin/v1/createaccount")]
        public string CreateAccount()
        {
            CreateAccountRequest loginCachedRequest = JsonConvert.DeserializeObject<CreateAccountRequest>(new StreamReader(HttpContext.Request.Body).ReadToEndAsync().Result);
            return Login.CreateAccount(loginCachedRequest.PlatformId.Remove(0, 10), loginCachedRequest.PlatformId);
        }

        [Route("/api/platformlogin/v1/logincached")]
        public string GetCachedLogin()
        {
            LoginCachedRequest loginCachedRequest = JsonConvert.DeserializeObject<LoginCachedRequest>(new StreamReader(HttpContext.Request.Body).ReadToEndAsync().Result);
            return Login.GetCachedLogin(loginCachedRequest.PlayerId);
        }

        [Route("/api/PlayerReporting/v1/moderationBlockDetails")]
        public string ModerationBlockOrNoBlock()
        {
            return JsonConvert.SerializeObject(new ModerationBlockDetails());//you can only do this if the values are set in the class
        }

        [Route("/api/presence/v1/setplayertype")]
        public string SetPlayerType()
        {
            return "[]";
        }

        [Route("/api/messages/v2/get")]
        public string GetMessages()
        {
            return "[]";
        }

        [Route("/api/relationships/v2/get")]
        public string GetRelationships()
        {
            return "[]";
        }

        [Route("/api/playersubscriptions/v1/my")]
        public string PlayerSubscriptionsV1()
        {
            return "[]";
        }

        [Route("/api/config/v1/amplitude")]
        public string ConfigAmplitude()
        {
            return JsonConvert.SerializeObject(new ConfigV1Amplitude());//you can only do this if the values are set in the class
        }

        [Route("/api/avatar/v2")]
        public string AvatarV2()
        {
            return System.IO.File.ReadAllText(Environment.CurrentDirectory + $"/Data/Profile/{UserIds[HttpContext.Connection.RemoteIpAddress.ToString()]}/avatar.json");
        }

        [Route("/api/settings/v2/")]
        public string SettingsV2()
        {
            return System.IO.File.ReadAllText(Environment.CurrentDirectory + $"/Data/Profile/{UserIds[HttpContext.Connection.RemoteIpAddress.ToString()]}/settings.json");
        }

        [Route("/api/avatar/v3/items")]
        public string AvatarItems()
        {
            return "[]";
        }

        [Route("/api/settings/v2/set")]
        public string SetSettingsV2()
        {
            return "[]";
        }

        [Route("/api/avatar/v3/Saved")]
        public string SavedAvatars()
        {
            return "[]";
        }

        [Route("/api/equipment/v1/getUnlocked")]
        public string EquipmentGetUnlocked()
        {
            return "[]";
        }

        [Route("/api/consumables/v1/getUnlocked")]
        public string ConsumablesGetUnlocked()
        {
            return "[]";
        }

        [Route("/api/avatar/v2/gifts")]
        public string AvatarV2Gifts()
        {
            return "[]";
        }

        [Route("/api/objectives/v1/myprogress")]
        public string ObjectivesV1MyProgress()
        {
            return System.IO.File.ReadAllText(Environment.CurrentDirectory + $"/Data/objectives.json");
        }

        [Route("/api/checklist/v1/current")]
        public string CurrentChecklist()
        {
            return "[{\"Order\":0,\"Objective\":3000,\"Count\":3,\"CreditAmount\":100},{\"Order\":1,\"Objective\":3001,\"Count\":3,\"CreditAmount\":100},{\"Order\":2,\"Objective\":3002,\"Count\":3,\"CreditAmount\":100}]";
        }

        [Route("/api/playerevents/v1/all")]
        public string AllPlayerEvents()
        {
            return "{\"Created\":[],\"Responses\":[]}";
        }

        [Route("/api/gamesessions/v3/joinroom")]
        public string JoinRoom()
        {
            return GameSessions.JoinRoom(UserIds[HttpContext.Connection.RemoteIpAddress.ToString()]);
        }

        [Route("/api/presence/v3/heartbeat")]
        public string PresenceHeartbeat()
        {
            return JsonConvert.SerializeObject(new
            {
                Error = "",
                Presence = Presence.GetPresence(UserIds[HttpContext.Connection.RemoteIpAddress.ToString()])
            });
        }

        /* this stores the userid by:
          taking the ip of the user(don't use(or store) the person's ip to use it against them please)
          and using it as a key that returns the userid of the person
          to get it in here you do UserIds[HttpContext.Connection.RemoteIpAddress.ToString()]
          to get it in the Notification class you do UserIds[Context.UserEndPoint.Address.ToString()]
          */
        public static SortedDictionary<string, ulong> UserIds = new SortedDictionary<string, ulong>();
    }
}
