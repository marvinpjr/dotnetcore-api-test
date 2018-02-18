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
    [Produces("application/json")]
    public class TeamPlayersController : Controller
    {
        private readonly ITeamService teamService;

        public TeamPlayersController(ITeamService teamService)
        {
            this.teamService = teamService;
        }

        /// <summary>
        /// Add a player to a team.
        /// </summary>
        /// <param name="teamId">Id of the team.</param>
        /// <param name="playerId">Id of the player to add.</param>
        /// <returns>The team that the player has been added to.</returns>
        [HttpPost]        
        public Team Add([FromBody] int teamId, int playerId)
        {
            return teamService.AddPlayerToTeam(playerId, teamId);
        }

        /// <summary>
        /// Retrieve the players on the specified team.
        /// </summary>
        /// <param name="teamId">The id of the team being requested.</param>
        /// <returns>A list of players on that team.</returns>        
        /// <response code="400">Team was not found.</response>  
        [HttpGet("{teamId}")]        
        [ProducesResponseType(typeof(IEnumerable<Player>), 400)]
        public IEnumerable<Player> TeamPlayers([FromRoute] int teamId)
        {
            return teamService.GetPlayersOnTeam(teamId);
        }
    }
}