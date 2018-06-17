using StatKeeper.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatKeeper.Api.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly StatKeeperContext statKeeperContext;

        public TeamRepository(StatKeeperContext context)
        {
            statKeeperContext = context;
        }

        public Team Create(Team newTeam)
        {
            var entry = statKeeperContext.Teams.Add(newTeam);
            statKeeperContext.SaveChanges();            
            return newTeam;
        }

        public bool Delete(Team team)
        {
            statKeeperContext.Remove(team);
            return statKeeperContext.SaveChanges() != 0;
        }
        
        public Team GetTeam(int teamId)
        {
            return statKeeperContext.Teams.SingleOrDefault(t => t.TeamId == teamId);
        }

        public IEnumerable<Team> GetTeams()
        {
            return statKeeperContext.Teams.ToList<Team>();
        }

        public Team Update(Team team)
        {
            throw new NotImplementedException();
        }
    }

    public interface ITeamRepository
    {
        Team Create(Team newTeam);
        bool Delete(Team team);
        Team GetTeam(int teamId);
        IEnumerable<Team> GetTeams();
        Team Update(Team team);
    }
}
