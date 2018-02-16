using StatsKeeper.Api.Model;
using System.Collections.Generic;
using System.Linq;

namespace StatsKeeper.Api.Services
{
    public class TeamService: ITeamService
    {
        private static List<Team> teams;
        private static int counter;

        public TeamService()
        {
            teams = new List<Team>
            {
                new Team() {Id=1, Name="Eagles", Players=new List<Player>()},
                new Team() {Id=2, Name="Patriots", Players=new List<Player>()}
            };
            counter = teams.Count;
        }

        public Team Create(Team newTeam)
        {
            counter++;
            newTeam.Id = counter;
            teams.Add(newTeam);
            return newTeam;
        }

        public bool Delete(int id)
        {
            var team = teams.SingleOrDefault(t => t.Id == id);
            if (team == null) return false;
            int index = teams.IndexOf(team);
            teams.RemoveAt(index);
            return true;
        }

        public Team Update(Team team)
        {
            var teamToUpdate = teams.SingleOrDefault(t => t.Id == team.Id);
            if (teamToUpdate == null) throw new KeyNotFoundException("No team with that id was found.");
            teamToUpdate.Name = team.Name;
            teamToUpdate.Players = team.Players;
            return teamToUpdate;
        }

        public Team GetTeam(int id)
        {
            return teams.Single(t => t.Id == id);
        }

        public IEnumerable<Team> GetTeams()
        {
            return teams;
        }
    }

    public interface ITeamService
    {
        IEnumerable<Team> GetTeams();
        Team GetTeam(int id);
        Team Create(Team newTeam);
        bool Delete(int id);
        Team Update(Team team);
    }
}
