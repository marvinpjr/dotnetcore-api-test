using Microsoft.AspNetCore.Mvc;
using StatsKeeper.Api.Model;
using StatsKeeper.Api.Services;

namespace StatsKeeper.Api.Controllers
{
    [Route("api/team")]
    public class TeamController : Controller
    {
        private readonly ITeamService teamService;

        public TeamController(ITeamService teamService)
        {
            this.teamService = teamService;
        }

        [HttpGet("{id}")]
        //[Route("team/{id}")]        
        public Team GetTeam([FromRoute]int id)
        {
            return teamService.GetTeam(id);
        }

        [HttpPost]
        //[Route("team/create")]
        public Team Create([FromBody] Team team)
        {
            return teamService.Create(team);
        }
        
        [HttpDelete]
        //[Route("team/delete")]        
        public bool Delete([FromBody] int id)
        {
            return teamService.Delete(id);
        }

        [HttpPut]
        //[Route("teams/update")]        
        public Team Update([FromBody] Team team)
        {
            return teamService.Update(team);
        }
    }
}