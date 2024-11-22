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
            File.WriteAllText(Environment.CurrentDirectory + $"/Data/Profile/{userid}/avatar.json", "{\"OutfitSelections\":\"de0ac50d-2adb-4114-bd2e-68953b13d706,05ac07e1-67f0-486c-abf5-a62866475abb,,,1;76369aef-aeda-46d2-996a-cd00594d0543,,,,0;193a3bf9-abc0-4d78-8d63-92046908b1c5,,,,0;3dec4865-cf23-4c19-a460-dd2db80ee851,e821aa74-2d47-4388-bcfb-1893b8a83a52,,,2;3dec4865-cf23-4c19-a460-dd2db80ee851,e821aa74-2d47-4388-bcfb-1893b8a83a52,,,3\",\"FaceFeatures\":\"{\\\"ver\\\":3,\\\"eyeId\\\":\\\"AjGMoJhEcEehacRZjUMuDg\\\",\\\"eyePos\\\":{\\\"x\\\":0.0,\\\"y\\\":0.0},\\\"eyeScl\\\":0.0,\\\"mouthId\\\":\\\"FrZBRanXEEK29yKJ4jiMjg\\\",\\\"mouthPos\\\":{\\\"x\\\":0.0,\\\"y\\\":0.0},\\\"mouthScl\\\":0.0,\\\"beardColorId\\\":\\\"f2707f7d-0ca9-4f4f-96a7-2d57a8cbe54e\\\"}\",\"SkinColor\":\"85343b16-d58a-4091-96d8-083a81fb03ae\",\"HairColor\":\"f2707f7d-0ca9-4f4f-96a7-2d57a8cbe54e\"}");
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
