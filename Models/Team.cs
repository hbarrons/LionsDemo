namespace LionsDemo.Models
{
    public class Team
    {
        public Team(int teamId, string name, string teamAbbr, string city, string stadium)
        {
            TeamId = teamId;
            Name = name;
            TeamAbbr = teamAbbr;
            City = city;
            Stadium = stadium;
        }

        public int TeamId { get; set; }
        public string Name { get; set; }
        public string TeamAbbr { get; set; }
        public string City { get; set; }
        public string Stadium { get; set; }
    }
}
