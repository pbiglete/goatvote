namespace goatvote.api.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int TotalGamesPlayed { get; set; }
        public int TotalMinutesPlayed { get; set; }
        public int TotalPoints { get; set; }
        public int TotalSeasonsPlayed { get; set; }
        public int TotalPlayoffGames { get; set; }
        public int TotalAllStarGames { get; set; }
        public int Total50PointPlusGames { get; set; }
        public int NBAChampionships { get; set; }
        public int MVPAwards { get; set; }
        public int FinalMVPAwards { get; set; }
        public int AllNBASelections { get; set; }
        public float PointsPerGame { get; set; }
        public float ReboundsPerGame { get; set; }
        public float AssistsPerGame { get; set; }
        public float BlocksPerGame { get; set; }
        public float StealsPerGame { get; set; }
        public float FGPercentage { get; set; }
        public float FG3Percentage { get; set; }
        public float FTPercentage { get; set; }
        public float PlayerEffeciencyRating { get; set; }

    }
}