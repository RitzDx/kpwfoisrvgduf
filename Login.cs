using CrypticSource.JsonClasses;
using Newtonsoft.Json;

namespace CrypticSource.Data
{
    public class Login
    {
        public static string GetCachedLogins(ulong userid)
        {
            if (!System.IO.Directory.Exists(Environment.CurrentDirectory + $"/Data/Profile/{userid}"))
            {
                return "[]";
            }
            else
            {
                return File.ReadAllText(Environment.CurrentDirectory + $"/Data/Profile/{userid}/profiles.json");
            }
        }

        public static string GetCachedLogin(ulong userid)
        {
            return JsonConvert.SerializeObject(new LoginCached
            {
                Error = "",
                Player = JsonConvert.DeserializeObject<Profile>(File.ReadAllText(Environment.CurrentDirectory + $"/Data/Profile/{userid}/{userid}.json")),
                Token = "",
                FirstLoginOfTheDay = false,
                AnalyticsSessionId = 0
            });
        }

        public static string CreateAccount(string userid, string platformid)
        {
            Directory.CreateDirectory(Environment.CurrentDirectory + $"/Data/Profile/{userid}");
            string name = "User:" + new Random().Next(0, int.MaxValue);
            List<Profile> profiles = new List<Profile>();
            Profile profile = new Profile
            {
                Id = Convert.ToUInt32(userid),
                Username = name,
                DisplayName = name,
                Bio = "",
                XP = 0,
                Level = 0,
                RegistrationStatus = 2,
                Developer = false,
                CanReceiveInvites = false,
                ProfileImageName = name,
                JuniorProfile = false,
                ForceJuniorImages = false,
                PendingJunior = false,
                HasBirthday = true,
                AvoidJuniors = false,
                PlayerReputation = new PlayerReputation
                {
                    Noteriety = 0f,
                    CheerGeneral = 0,
                    CheerHelpful = 0,
                    CheerGreatHost = 0,
                    CheerSportsman = 0,
                    CheerCreative = 0,
                    CheerCredit = 0,
                    SubscriberCount = 0,
                    SubscribedCount = 0,
                    SelectedCheer = 0
                },
                PlatformId = new PlatformIds
                {
                    Platform = 0,
                    PlatformId = platformid
                }
            };
            profiles.Add(profile);
            File.WriteAllText(Environment.CurrentDirectory + $"/Data/Profile/{userid}/profiles.json", JsonConvert.SerializeObject(profiles));
            File.WriteAllText(Environment.CurrentDirectory + $"/Data/Profile/{userid}/{userid}.json", JsonConvert.SerializeObject(profile));
            File.WriteAllText(Environment.CurrentDirectory + $"/Data/Profile/{userid}/avatar.json", "{\"OutfitSelections\":\"b33dbeee-5bdd-443d-aa6a-761248054e08,,,,1;6d48c545-22bb-46c1-a29d-0a38af387143,,,,2;6d48c545-22bb-46c1-a29d-0a38af387143,,,,3;193a3bf9-abc0-4d78-8d63-92046908b1c5,,,,0;47629ed1-5378-427c-ad61-4b44d2fe90cc,7b82c3c5-fd1f-45ec-b83f-e32668aa8dce,,,0;2e5afc40-7e25-418c-8b1b-316b8ef479a7,e1f49b74-b071-4bd1-9c4b-af36d24d45c5,,,1;b6rLwzD4NkKV7xKn9ZYVkA,,,,1;102c625b-b988-4bf8-a2aa-a31ad7029cdc,,,,0;4763436c-2dcc-482a-bf37-a6b16d7aae6e,a089bcc6-798d-4777-98e2-7afd290dc6b6,,,2;4763436c-2dcc-482a-bf37-a6b16d7aae6e,a089bcc6-798d-4777-98e2-7afd290dc6b6,,,3\",\"FaceFeatures\":\"{\\\"ver\\\":3,\\\"eyeId\\\":\\\"AjGMoJhEcEehacRZjUMuDg\\\",\\\"eyePos\\\":{\\\"x\\\":-0.009999999776482582,\\\"y\\\":0.0},\\\"eyeScl\\\":0.05000000074505806,\\\"mouthId\\\":\\\"FrZBRanXEEK29yKJ4jiMjg\\\",\\\"mouthPos\\\":{\\\"x\\\":0.0,\\\"y\\\":0.05999999865889549},\\\"mouthScl\\\":0.05000000074505806,\\\"beardColorId\\\":\\\"befcc00a-a2e6-48e4-864c-593d57bbbb5b\\\"}\",\"SkinColor\":\"GSPNannQpkG6xVTd7oj9pg\",\"HairColor\":\"fT0t-J1A-0i_tdoogFEz-g\"}");
            File.WriteAllText(Environment.CurrentDirectory + $"/Data/Profile/{userid}/settings.json", "[{\"Key\":\"MOD_BLOCKED_TIME\",\"Value\":\"0\"},{\"Key\":\"MOD_BLOCKED_DURATION\",\"Value\":\"0\"},{\"Key\":\"PlayerSessionCount\",\"Value\":\"145\"},{\"Key\":\"ShowRoomCenter\",\"Value\":\"1\"},{\"Key\":\"QualitySettings\",\"Value\":\"3\"},{\"Key\":\"Recroom.OOBE\",\"Value\":\"100\"},{\"Key\":\"VoiceFilter\",\"Value\":\"0\"},{\"Key\":\"VIGNETTED_TELEPORT_ENABLED\",\"Value\":\"0\"},{\"Key\":\"CONTINUOUS_ROTATION_MODE\",\"Value\":\"0\"},{\"Key\":\"ROTATION_INCREMENT\",\"Value\":\"0\"},{\"Key\":\"ROTATE_IN_PLACE_ENABLED\",\"Value\":\"0\"},{\"Key\":\"TeleportBuffer\",\"Value\":\"0\"},{\"Key\":\"VoiceChat\",\"Value\":\"1\"},{\"Key\":\"PersonalBubble\",\"Value\":\"0\"},{\"Key\":\"ShowNames\",\"Value\":\"1\"},{\"Key\":\"H.264 plugin\",\"Value\":\"1\"},{\"Key\":\"FIRST_TIME_IN_FLAGS\",\"Value\":\"0\"},{\"Key\":\"PlayerSessionCount\",\"Value\":\"145\"},{\"Key\":\"USER_TRACKING\",\"Value\":\"36\"},{\"Key\":\"VoiceChat\",\"Value\":\"1\"}]");
            return JsonConvert.SerializeObject(new LoginCached
            {
                Error = "",
                Player = profile,
                Token = "",
                FirstLoginOfTheDay = false,
                AnalyticsSessionId = 0
            });
        }
    }
}
