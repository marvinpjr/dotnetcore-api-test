using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StatsKeeper.Api.Model;
using StatsKeeper.Api.Services;

namespace StatsKeeper.Api.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayerService playerService;

        public PlayerController(IPlayerService playerService)
        {
            this.playerService = playerService;
        }

        [HttpGet]
        [Route("player/all")]
        public IEnumerable<Player> Players()
        {
            return playerService.GetPlayers();
        }

        [HttpGet("{id}")]
        [Route("player/{id}")]
        public Player Player(int id)
        {
            return playerService.GetPlayer(id);
        }

        [HttpPost]
        [Route("player/create")]
        public Player Create([FromBody]Player player)
        {
            return playerService.Create(player);
        }

        [HttpDelete("{id}")]
        [Route("player/delete/{id}")]
        public bool Delete(int id)
        {
            return playerService.Delete(id);
        }

        [HttpPut]
        [Route("player/update")]
        public Player Update([FromBody]Player player)
        {
            return playerService.Update(player);
        }
    }
}