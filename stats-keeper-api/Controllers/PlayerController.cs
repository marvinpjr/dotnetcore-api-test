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
        public IEnumerable<Player> Players()
        {
            return playerService.GetPlayers();
        }

        [HttpGet("{id}")]
        public Player Player(int id)
        {
            return playerService.GetPlayer(id);
        }

        [HttpPost]
        public Player Create([FromBody]Player player)
        {
            return playerService.Create(player);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return playerService.Delete(id);
        }

        [HttpPut]
        public Player Update([FromBody]Player player)
        {
            return playerService.Update(player);
        }
    }
}