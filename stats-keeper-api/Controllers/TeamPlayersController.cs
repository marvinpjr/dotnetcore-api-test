using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StatsKeeper.Api.Model;
using StatsKeeper.Api.Services;

namespace StatsKeeper.Api.Controllers
{
    [Route("api/teamplayers")]
    public class TeamPlayersController : Controller
    {
        private readonly ITeamService teamService;

        public TeamPlayersController(ITeamService teamService)
        {
            this.teamService = teamService;
        }

        [HttpPost]
        //[Route("teams/{teamId}/add/player/{playerId}")]
        public Team Add([FromBody] int teamId, int playerId)
        {
            return teamService.AddPlayerToTeam(playerId, teamId);
        }

        [HttpGet("{teamId}")]
        //[Route("teams/{teamId}/players")]        
        public IEnumerable<Player> TeamPlayers([FromRoute] int teamId)
        {
            return teamService.GetPlayersOnTeam(teamId);
        }
    }
}