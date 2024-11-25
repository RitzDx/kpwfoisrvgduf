using CrypticSource.WebSocket;

string hotrooms = Directory.GetCurrentDirectory() + "/Data/hotrooms.txt";

var builder = WebApplication.CreateBuilder(args);

/* this checks if the data directory does not exist
   and if it does not exist it creates the data directory
*/
if (!Directory.Exists(Environment.CurrentDirectory + "/Data"))
{
    Directory.CreateDirectory(Environment.CurrentDirectory + "/Data");
}

builder.Services.AddHttpLogging(configureOptions => {});

builder.Services.AddControllers();

File.Create(hotrooms).Close();

// Hot rooms text file
File.WriteAllText(hotrooms, "[\n    {\n        \"RoomId\": 29,\n        \"Name\": \"RecCenter\",\n        \"Description\": \"Meet up with ur friends, harass women online, this is free country Genesis!\",\n        \"CreatorPlayerId\": 1,\n        \"ImageName\": \"CustomRoom.png\",\n        \"State\": 0,\n        \"Accessibility\": 1,\n        \"SupportsLevelVoting\": false,\n        \"IsAGRoom\": true,\n        \"CloningAllowed\": false,\n        \"SupportsScreens\": true,\n        \"SupportsWalkVR\": true,\n        \"SupportsTeleportVR\": true\n    },\n    {\n        \"RoomId\": 3,\n        \"Name\": \"3DCharades\",\n        \"Description\": \"Take turns drawing, acting, and guessing funny phrases with your friends!\",\n        \"CreatorPlayerId\": 72963398,\n        \"ImageName\": \"a446d5808ed14401a27f53e631c31b93.png\",\n        \"State\": 0,\n        \"Accessibility\": 1,\n        \"SupportsLevelVoting\": false,\n        \"IsAGRoom\": true,\n        \"CloningAllowed\": false,\n        \"SupportsScreens\": true,\n        \"SupportsWalkVR\": true,\n        \"SupportsTeleportVR\": true\n    },\n    {\n        \"RoomId\": 4,\n        \"Name\": \"DiscGolfLake\",\n        \"Description\": \"Throw your disc into the goal. Sounds easy, right?\",\n        \"CreatorPlayerId\": 72963398,\n        \"ImageName\": \"52cf6c3271894ecd95fb0c9b2d2209a7\",\n        \"State\": 0,\n        \"Accessibility\": 1,\n        \"SupportsLevelVoting\": false,\n        \"IsAGRoom\": true,\n        \"CloningAllowed\": false,\n        \"SupportsScreens\": true,\n        \"SupportsWalkVR\": true,\n        \"SupportsTeleportVR\": true\n    },\n    {\n        \"RoomId\": 5,\n        \"Name\": \"DiscGolfPropulsion\",\n        \"Description\": \"Throw your disc into the goal. Sounds easy, right?\",\n        \"CreatorPlayerId\": 72963398,\n        \"ImageName\": \"fc9a1acc47514b64a30d199d5ccdeca9\",\n        \"State\": 0,\n        \"Accessibility\": 1,\n        \"SupportsLevelVoting\": false,\n        \"IsAGRoom\": true,\n        \"CloningAllowed\": false,\n        \"SupportsScreens\": true,\n        \"SupportsWalkVR\": true,\n        \"SupportsTeleportVR\": true\n    },\n    {\n        \"RoomId\": 6,\n        \"Name\": \"Dodgeball\",\n        \"Description\": \"Throw dodgeballs to knock out your friends in this gym classic!\",\n        \"CreatorPlayerId\": 72963398,\n        \"ImageName\": \"6d5c494668784816bbc41d9b870e5003\",\n        \"State\": 0,\n        \"Accessibility\": 1,\n        \"SupportsLevelVoting\": false,\n        \"IsAGRoom\": true,\n        \"CloningAllowed\": false,\n        \"SupportsScreens\": true,\n        \"SupportsWalkVR\": true,\n        \"SupportsTeleportVR\": true\n    },\n    {\n        \"RoomId\": 7,\n        \"Name\": \"Paddleball\",\n        \"Description\": \"A simple rally game between two players in a plexiglass tube with a zero-g ball.\",\n        \"CreatorPlayerId\": 72963398,\n        \"ImageName\": \"ffdca6ed8bd94631ac15e3e894acb6c6\",\n        \"State\": 0,\n        \"Accessibility\": 1,\n        \"SupportsLevelVoting\": false,\n        \"IsAGRoom\": true,\n        \"CloningAllowed\": false,\n        \"SupportsScreens\": true,\n        \"SupportsWalkVR\": true,\n        \"SupportsTeleportVR\": true\n    },\n    {\n        \"RoomId\": 8,\n        \"Name\": \"Paintball\",\n        \"Description\": \"Red and Blue teams splat each other in capture the flag and team battle.\",\n        \"CreatorPlayerId\": 72963398,\n        \"ImageName\": \"93a53ced93a04f658795a87f4a4aab85\",\n        \"State\": 0,\n        \"Accessibility\": 1,\n        \"SupportsLevelVoting\": true,\n        \"IsAGRoom\": true,\n        \"CloningAllowed\": false,\n        \"SupportsScreens\": true,\n        \"SupportsWalkVR\": true,\n        \"SupportsTeleportVR\": true\n    },\n    {\n        \"RoomId\": 13,\n        \"Name\": \"GoldenTrophy\",\n        \"Description\": \"The goblin king stole Coach's Golden Trophy. Team up and embark on an epic quest to recover it!\",\n        \"CreatorPlayerId\": 72963398,\n        \"ImageName\": \"38e9d0d4eff94556a0b106508249dcf9\",\n        \"State\": 0,\n        \"Accessibility\": 1,\n        \"SupportsLevelVoting\": false,\n        \"IsAGRoom\": true,\n        \"CloningAllowed\": false,\n        \"SupportsScreens\": true,\n        \"SupportsWalkVR\": true,\n        \"SupportsTeleportVR\": true\n    },\n    {\n        \"RoomId\": 14,\n        \"Name\": \"TheRiseofJumbotron\",\n        \"Description\": \"Robot invaders threaten the galaxy! Team up with your friends and bring the laser heat!\",\n        \"CreatorPlayerId\": 72963398,\n        \"ImageName\": \"51296f28105b48178708e389b6daf057\",\n        \"State\": 0,\n        \"Accessibility\": 1,\n        \"SupportsLevelVoting\": false,\n        \"IsAGRoom\": true,\n        \"CloningAllowed\": false,\n        \"SupportsScreens\": true,\n        \"SupportsWalkVR\": true,\n        \"SupportsTeleportVR\": true\n    },\n    {\n        \"RoomId\": 15,\n        \"Name\": \"CrimsonCauldron\",\n        \"Description\": \"Can your band of adventurers brave the enchanted wilds, and lift the curse of the crimson cauldron?\",\n        \"CreatorPlayerId\": 72963398,\n        \"ImageName\": \"3ab82779dff94d11920ebf38df249395\",\n        \"State\": 0,\n        \"Accessibility\": 1,\n        \"SupportsLevelVoting\": false,\n        \"IsAGRoom\": true,\n        \"CloningAllowed\": false,\n        \"SupportsScreens\": true,\n        \"SupportsWalkVR\": true,\n        \"SupportsTeleportVR\": true\n    },\n    {\n        \"RoomId\": 16,\n        \"Name\": \"IsleOfLostSkulls\",\n        \"Description\": \"Can your pirate crew get to the Isle, defeat its fearsome guardian, and escape with the gold?\",\n        \"CreatorPlayerId\": 72963398,\n        \"ImageName\": \"45ad53aa002646d0ab3eb509b9f260ef\",\n        \"State\": 0,\n        \"Accessibility\": 1,\n        \"SupportsLevelVoting\": false,\n        \"IsAGRoom\": true,\n        \"CloningAllowed\": false,\n        \"SupportsScreens\": true,\n        \"SupportsWalkVR\": true,\n        \"SupportsTeleportVR\": true\n    },\n    {\n        \"RoomId\": 17,\n        \"Name\": \"Soccer\",\n        \"Description\": \"Teams of three run around slamming themselves into an over-sized soccer ball. Goal!\",\n        \"CreatorPlayerId\": 72963398,\n        \"ImageName\": \"51c6f5ac5e6f4777b573e7e43f8a85ea\",\n        \"State\": 0,\n        \"Accessibility\": 1,\n        \"SupportsLevelVoting\": false,\n        \"IsAGRoom\": true,\n        \"CloningAllowed\": false,\n        \"SupportsScreens\": true,\n        \"SupportsWalkVR\": true,\n        \"SupportsTeleportVR\": true\n    },\n    {\n        \"RoomId\": 18,\n        \"Name\": \"LaserTag\",\n        \"Description\": \"Teams battle each other and waves of robots.\",\n        \"CreatorPlayerId\": 72963398,\n        \"ImageName\": \"c5a72193d6904811b2d0195a6deb3125\",\n        \"State\": 0,\n        \"Accessibility\": 1,\n        \"SupportsLevelVoting\": false,\n        \"IsAGRoom\": true,\n        \"CloningAllowed\": false,\n        \"SupportsScreens\": true,\n        \"SupportsWalkVR\": true,\n        \"SupportsTeleportVR\": true\n    },\n    {\n        \"RoomId\": 20,\n        \"Name\": \"RecRoyaleSquads\",\n        \"Description\": \"Squads of three battle it out on Frontier Island. Last squad standing wins!\",\n        \"CreatorPlayerId\": 72963398,\n        \"ImageName\": \"69fc525056014e39a435c4d2fdf2b887\",\n        \"State\": 0,\n        \"Accessibility\": 1,\n        \"SupportsLevelVoting\": false,\n        \"IsAGRoom\": true,\n        \"CloningAllowed\": false,\n        \"SupportsScreens\": true,\n        \"SupportsWalkVR\": true,\n        \"SupportsTeleportVR\": true\n    },\n    {\n        \"RoomId\": 21,\n        \"Name\": \"RecRoyaleSolos\",\n        \"Description\": \"Battle it out on Frontier Island. Last person standing wins!\",\n        \"CreatorPlayerId\": 72963398,\n        \"ImageName\": \"f9e112bb67fb430d979e5ad6c2c116d4\",\n        \"State\": 0,\n        \"Accessibility\": 1,\n        \"SupportsLevelVoting\": false,\n        \"IsAGRoom\": true,\n        \"CloningAllowed\": false,\n        \"SupportsScreens\": true,\n        \"SupportsWalkVR\": true,\n        \"SupportsTeleportVR\": true\n    },\n    {\n        \"RoomId\": 22,\n        \"Name\": \"Lounge\",\n        \"Description\": \"A low-key lounge to chill with your friends. Great for private parties!\",\n        \"CreatorPlayerId\": 72963398,\n        \"ImageName\": \"3e8c2458f1e542ab8aa275e4083ee47a\",\n        \"State\": 0,\n        \"Accessibility\": 1,\n        \"SupportsLevelVoting\": false,\n        \"IsAGRoom\": true,\n        \"CloningAllowed\": false,\n        \"SupportsScreens\": true,\n        \"SupportsWalkVR\": true,\n        \"SupportsTeleportVR\": true\n    },\n    {\n        \"RoomId\": 25,\n        \"Name\": \"Park\",\n        \"Description\": \"A sprawling park with amphitheater, play fields, and a cave.\",\n        \"CreatorPlayerId\": 72963398,\n        \"ImageName\": \"79ee7af2532247f397867e48daa9d264.png\",\n        \"State\": 0,\n        \"Accessibility\": 1,\n        \"SupportsLevelVoting\": false,\n        \"IsAGRoom\": true,\n        \"CloningAllowed\": false,\n        \"SupportsScreens\": true,\n        \"SupportsWalkVR\": true,\n        \"SupportsTeleportVR\": true\n    },\n    {\n        \"RoomId\": 27,\n        \"Name\": \"QuestForDraucula\",\n        \"Description\": \"Gather your vampire hunting crew, conquer a legendary castle, and restore peace to Rec Room!\",\n        \"CreatorPlayerId\": 72963398,\n        \"ImageName\": \"d0df003353914adfaecdd23f428208b6\",\n        \"State\": 0,\n        \"Accessibility\": 1,\n        \"SupportsLevelVoting\": false,\n        \"IsAGRoom\": true,\n        \"CloningAllowed\": false,\n        \"SupportsScreens\": true,\n        \"SupportsWalkVR\": true,\n        \"SupportsTeleportVR\": true\n    },\n    {\n        \"RoomId\": 2,\n        \"Name\": \"RecCenter\",\n        \"Description\": \"A social hub to meet and mingle with friends new and old.\",\n        \"CreatorPlayerId\": 72963398,\n        \"ImageName\": \"22eefa3219f046fd9e2090814650ede3\",\n        \"State\": 0,\n        \"Accessibility\": 1,\n        \"SupportsLevelVoting\": false,\n        \"IsAGRoom\": true,\n        \"CloningAllowed\": false,\n        \"SupportsScreens\": true,\n        \"SupportsWalkVR\": true,\n        \"SupportsTeleportVR\": true\n    },\n    {\n        \"RoomId\": 28,\n        \"Name\": \"Bowling\",\n        \"Description\": \"Hang out with friends, bowl a few games, eat snacks!\",\n        \"CreatorPlayerId\": 72963398,\n        \"ImageName\": \"4d143a3359e8483e8d48116ab6cacecb\",\n        \"State\": 0,\n        \"Accessibility\": 1,\n        \"SupportsLevelVoting\": false,\n        \"IsAGRoom\": true,\n        \"CloningAllowed\": false,\n        \"SupportsScreens\": true,\n        \"SupportsWalkVR\": true,\n        \"SupportsTeleportVR\": true\n    }\n]\n");

var app = builder.Build();

app.UseAuthorization();

app.UseHttpLogging();

app.MapControllers();

new WebSocket();

app.Run();
