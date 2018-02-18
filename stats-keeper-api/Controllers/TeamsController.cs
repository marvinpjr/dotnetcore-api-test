using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StatsKeeper.Api.Model;
using StatsKeeper.Api.Services;

namespace StatsKeeper.Api.Controllers
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