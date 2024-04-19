namespace CrypticSource.JsonClasses
{
    public class ConfigV2
    {
        public string? MessageOfTheDay { get; set; } = "this shouldn't work i think";
        public string? CdnBaseUri { get; set; } = "http://localhost:7689";
        public MatchmakingParams MatchmakingParams { get; set; } = new MatchmakingParams();
        public ServerMaintenance ServerMaintenance { get; set; } = new ServerMaintenance();
        public LevelProgressionMaps[] LevelProgressionMaps { get; set; } = [new LevelProgressionMaps { Level = 1, RequiredXp = 100 }, new LevelProgressionMaps { Level = 2, RequiredXp = 200 }, new LevelProgressionMaps { Level = 3, RequiredXp = 300 }, new LevelProgressionMaps { Level = 4, RequiredXp = 400 }, new LevelProgressionMaps { Level = 5, RequiredXp = 500 }, new LevelProgressionMaps { Level = 6, RequiredXp = 600 }];
        public DailyObjectives[][] DailyObjectives { get; set; } = [[new DailyObjectives { type = DailyObjectivesTypesEnum.GoToRecCenter, score = 1, }, new DailyObjectives { type = DailyObjectivesTypesEnum.QuestWins, score = 1, }, new DailyObjectives { type = DailyObjectivesTypesEnum.DiscGolfWins, score = 1, }], [new DailyObjectives { type = DailyObjectivesTypesEnum.GoToRecCenter, score = 1, }, new DailyObjectives { type = DailyObjectivesTypesEnum.QuestWins, score = 1, }, new DailyObjectives { type = DailyObjectivesTypesEnum.DiscGolfWins, score = 1, }], [new DailyObjectives { type = DailyObjectivesTypesEnum.GoToRecCenter, score = 1, }, new DailyObjectives { type = DailyObjectivesTypesEnum.QuestWins, score = 1, }, new DailyObjectives { type = DailyObjectivesTypesEnum.DiscGolfWins, score = 1, }]];
        public PhotonConfig PhotonConfig { get; set; } = new PhotonConfig();
    }
}
