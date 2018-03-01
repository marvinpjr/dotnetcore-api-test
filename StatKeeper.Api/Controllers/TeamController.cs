using Microsoft.AspNetCore.Mvc;
using StatKeeper.Api.Model;
using StatKeeper.Api.Services;

namespace StatKeeper.Api.Controllers
{    
    [Route("api/team")]
    [Produces("application/json")]
    public class TeamController : Controller
    {
        private readonly ITeamService teamService;

        public TeamController(ITeamService teamService)
        {
            this.teamService = teamService;
        }

        /// <summary>
        /// Retrieve information about a single team.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The Team matching the supplied id.</returns>
        [HttpGet("{id}")]
        //[Route("team/{id}")]        
        public Team GetTeam([FromRoute]int id)
        {
            return teamService.GetTeam(id);
        }

        /// <summary>
        /// Create a new team.
        /// </summary>
        /// <param name="team"></param>
        /// <returns>A copy of the team that was created with the id that was assigned.</returns>
        /// <response code="201">Team created.</response>
        [HttpPost]
        [ProducesResponseType(typeof(Team), 201)]
        //[Route("team/create")]
        public Team Create([FromBody] Team team)
        {
            return teamService.Create(team);
        }
        
        /// <summary>
        /// Delete an existing team.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A value of true if the team was deleted successfully and false if it was not.</returns>
        [HttpDelete]
        //[Route("team/delete")]        
        public bool Delete([FromBody] int id)
        {
            var teamToDelete = teamService.GetTeam(id);
            return teamService.Delete(teamToDelete);
        }

        [HttpPut]
        //[Route("teams/update")]        
        public Team Update([FromBody] Team team)
        {
            return teamService.Update(team);
        }
    }
}