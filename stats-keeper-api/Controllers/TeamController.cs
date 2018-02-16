using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StatsKeeper.Api.Model;
using StatsKeeper.Api.Services;

namespace StatsKeeper.Api.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService teamService;

        public TeamController(ITeamService teamService)
        {
            this.teamService = teamService;
        }

        // GET /api/team/teams
        [HttpGet]  
        [Route("team/all")]
        public IEnumerable<Team> Teams()
        {
            return teamService.GetTeams();
        }

        // GET /api/team/team/1
        [HttpGet("{id}")]
        [Route("team/{id}")]
        public Team Team(int id)
        {
            return teamService.GetTeam(id);
        }

        // POST /api/team/create
        [HttpPost]
        [Route("team/create")]
        public Team Create([FromBody]Team team)
        {
            return teamService.Create(team);
        }

        // DELETE /api/team/delete/1
        [HttpDelete("{id}")]
        [Route("team/delete/{id}")]
        public bool Delete(int id)
        {
            return teamService.Delete(id);
        }

        // PUT /api/team/update
        [HttpPut]
        [Route("team/update")]
        public Team Update([FromBody]Team team)
        {
            return teamService.Update(team);
        }

        [HttpGet]
        [Route("team/{teamId}/add/player/{playerId}")]
        public Team Add(int teamId, int playerId)
        {
            return teamService.AddPlayerToTeam(playerId, teamId);
        }

        [HttpGet]
        [Route("team/{teamId}/players")]
        public IEnumerable<Player> Players(int teamId)
        {
            return teamService.GetPlayersOnTeam(teamId);
        }
            
    }
}