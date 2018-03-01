using StatKeeper.Api.Model;
using StatKeeper.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StatKeeper.Api.Services
{
    public class TeamService: ITeamService
    {
        private readonly IPlayerService playerService;
        private readonly ITeamRepository teamRepository;
        //private static List<Team> teams;
        //private static int counter;

        public TeamService(IPlayerService playerService, ITeamRepository teamRepository)
        {
            this.playerService = playerService;
            this.teamRepository = teamRepository;
            
            //teams = new List<Team>
            //{
            //    new Team() {Id=1, Name="Eagles", Players=new List<Player>()},
            //    new Team() {Id=2, Name="Patriots", Players=new List<Player>()}
            //};
            //counter = teams.Count;
        }

        public Team Create(Team newTeam)
        {
            return teamRepository.Create(newTeam);
            //counter++;
            //newTeam.Id = counter;
            //teams.Add(newTeam);
            //return newTeam;
        }

        public bool Delete(Team team)
        {
            //var team = teams.SingleOrDefault(t => t.Id == id);
            //if (team == null) return false;
            //int index = teams.IndexOf(team);
            //teams.RemoveAt(index);
            //return true;

            return teamRepository.Delete(team);
        }

        public Team Update(Team team)
        {
            //var teamToUpdate = teams.SingleOrDefault(t => t.Id == team.Id);
            //if (teamToUpdate == null) throw new KeyNotFoundException("No team with that id was found.");
            //teamToUpdate.Name = team.Name;
            //teamToUpdate.Players = team.Players;
            //return teamToUpdate;

            return teamRepository.Update(team);
        }

        public Team GetTeam(int id)
        {
            //return teams.Single(t => t.Id == id);

            return teamRepository.GetTeam(id);
        }

        public IEnumerable<Team> GetTeams()
        {
            //return teams;

            return teamRepository.GetTeams();
        }

        public IEnumerable<Player> GetPlayersOnTeam(int teamId)
        {
            throw new NotImplementedException();
            //var team = teams.SingleOrDefault(t => t.Id == teamId);
            //if (team == null) throw new KeyNotFoundException($"Team with id {teamId} wasn't found");
            //return team.Players;            
        }

        public Team AddPlayerToTeam(int playerId, int teamId)
        {
            //var player = playerService.GetPlayer(playerId);
            //if (player == null) throw new KeyNotFoundException($"Player with id {playerId} was not found.");

            //var team = teams.SingleOrDefault(t => t.Id == teamId);
            //if (team == null) throw new KeyNotFoundException($"Team with id {teamId} was not found.");

            //team.Players.Add(player);
            //return team;

            throw new NotImplementedException();
        }
    }

    public interface ITeamService
    {
        IEnumerable<Team> GetTeams();
        Team GetTeam(int id);
        Team Create(Team newTeam);
        bool Delete(Team team);
        Team Update(Team team);
        Team AddPlayerToTeam(int playerId, int teamId);
        IEnumerable<Player> GetPlayersOnTeam(int teamId);
    }
}
