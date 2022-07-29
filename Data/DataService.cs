using LionsDemo.Models;

namespace LionsDemo.Data
{
    public interface IDataService
    {
        public IEnumerable<Player> GetPlayers();
        public Player GetPlayerByName(string playerName);
        public IEnumerable<Team> GetTeams();
    }

    // This service represents where real data would come from a database
    public class DataService : IDataService
    {
        // OBJECTIVE: I should only return players who are not deleted in the system.
        public IEnumerable<Player> GetPlayers()
        {
            var players = Fakes.PlayerCollection;
            return players;
        }

        // OBJECTIVE: Right now, I only return players who exactly match a players last name, and am case sensitive.
        // Make it so I return any player whose first or last name contains the searched string, non case sensitive.
        public Player GetPlayerByName(string playerName)
        {
            var players = Fakes.PlayerCollection;
            return players.FirstOrDefault(p => p.LastName == playerName);
        }

        // OBJECTIVE: I should return a list of teams from the fake data repository, sorted alphabetically by name.  Right now I return an empty list.
        public IEnumerable<Team> GetTeams()
        {
            return new List<Team>();
        }
    }
}
