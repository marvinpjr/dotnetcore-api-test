using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StatsKeeper.Api.Model;

namespace StatsKeeper.Api.Controllers
{
    public class PlayerController : Controller
    {
        [HttpGet]
        public IEnumerable<Player> Players()
        {
            return new List<Player>();
        }

        [HttpGet("{id}")]
        public Player Player(int id)
        {
            return new Player();
        }

        [HttpPost]
        public Player Create([FromBody]Player player)
        {
            return player;
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return true;
        }

        [HttpPut]
        public Player Update([FromBody]Player player)
        {
            return player;
        }
    }
}