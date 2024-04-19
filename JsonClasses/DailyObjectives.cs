namespace CrypticSource.JsonClasses
{
    public class DailyObjectives
    {
        public DailyObjectivesTypesEnum type { get; set; } = DailyObjectivesTypesEnum.Default;
        public int score { get; set; } = 0;
    }
}
