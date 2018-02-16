using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StatsKeeper.Api.Model;

namespace StatsKeeper.Api.Controllers
{
    public class TeamController : Controller
    {
        [HttpGet]        
        public IEnumerable<Team> Teams()
        {
            return new List<Team>();
        }

        [HttpGet("{id}")]
        public Team Team(int id)
        {
            return new Team();
        }

        [HttpPost]
        public Team Create([FromBody]Team team)
        {
            return team;
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return true;
        }

        [HttpPut]
        public Team Update([FromBody]Team team)
        {
            return team;
        }
    }
}