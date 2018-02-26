using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StatsKeeper.Api.Model;
using StatsKeeper.Api.Services;

namespace StatsKeeper.Api.Controllers
{
    [Route("api/player")]
    [Produces("application/json")]
    public class PlayerController : Controller
    {
        private readonly IPlayerService playerService;

        public PlayerController(IPlayerService playerService)
        {
            this.playerService = playerService;
        }

        [HttpGet("{id}")]
        // [Route("player/{id}")]
        public Player Player(int id)
        {
            return playerService.GetPlayer(id);
        }

        [HttpPost]
        //[Route("players/create")]
        public Player Create([FromBody]Player player)
        {
            return playerService.Create(player);
        }

        [HttpDelete]
        //[Route("players/delete/{id}")]
        public bool Delete([FromBody]int id)
        {
            var playerToDelete = playerService.GetPlayer(id);
            return playerService.Delete(playerToDelete);
        }

        [HttpPut]
        //[Route("players/update")]
        public Player Update([FromBody]Player player)
        {
            return playerService.Update(player);
        }
    }
}