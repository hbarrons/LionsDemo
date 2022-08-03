using LionsDemo.Models;

namespace LionsDemo.Data
{
    public interface IDataService
    {
        public IEnumerable<Player> GetPlayers();
        public Player GetPlayer(int playerId);
        public IEnumerable<Player> GetPlayerByName(string playerName);
        public IEnumerable<Team> GetTeams();
    }

    // This service represents where real data would come from a database
    public class DataService : IDataService
    {
        // OBJECTIVE: I should only return players who are not deleted in the system.
        public IEnumerable<Player> GetPlayers()
        {
            var players = Fakes.PlayerCollection;
            //foreach (Player player in players.Where(p => p.Deleted == false))
            //{
            //    System.Console.WriteLine(player.FirstName);

            //}
            return players.Where(p => p.Deleted == false);
        }

        // OBJECTIVE: Right now, I only return players who exactly match a players last name, and am case sensitive.
        // Make it so I return any player whose first or last name contains the searched string, non case sensitive.
        public IEnumerable<Player> GetPlayerByName(string playerName)
        {
            var players = Fakes.PlayerCollection;
            System.Console.WriteLine(playerName);
            var searchedPlayers = players.Where(p => p.LastName.Equals(playerName, StringComparison.CurrentCultureIgnoreCase) || p.FirstName.Equals(playerName, StringComparison.CurrentCultureIgnoreCase));
            foreach (Player player in searchedPlayers)
            {
                System.Console.WriteLine(player.FirstName + " " + player.LastName);
            }
            return searchedPlayers;
        }

        // OBJECTIVE: I should return a list of teams from the fake data repository, sorted alphabetically by name.  Right now I return an empty list.
        public IEnumerable<Team> GetTeams()
        {
            var teams = Fakes.TeamCollection;
            foreach (Team team in teams)
            {
                System.Console.WriteLine(team.Name);
            }
            return teams.OrderBy(team => team.Name);
        }

        public Player GetPlayer(int playerId)
        {
            var players = Fakes.PlayerCollection;
            var selectedPlayer = players.FirstOrDefault(p => p.PlayerId == playerId);
            System.Console.WriteLine(playerId);
            return selectedPlayer;
        }
    }
}
