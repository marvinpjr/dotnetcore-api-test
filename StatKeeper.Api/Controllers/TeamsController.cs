using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StatKeeper.Api.Model;
using StatKeeper.Api.Services;

namespace StatKeeper.Api.Controllers
{
    [Route("api/teams")]
    [Produces("application/json")]
    public class TeamsController : Controller
    {
        private readonly ITeamService teamService;

        public TeamsController(ITeamService teamService)
        {
            this.teamService = teamService;
        }

        // GET /api/teams/all
        [HttpGet]  
        //[Route("teams")]
        public IEnumerable<Team> Teams()
        {
            return teamService.GetTeams();
        }
    }
}