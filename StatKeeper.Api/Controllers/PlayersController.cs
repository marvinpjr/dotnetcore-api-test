﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StatKeeper.Api.Model;
using StatKeeper.Api.Services;

namespace StatKeeper.Api.Controllers
{
    [Route("api/players")]
    [Produces("application/json")]
    public class PlayersController : Controller
    {
        private readonly IPlayerService playerService;

        public PlayersController(IPlayerService playerService)
        {
            this.playerService = playerService;
        }

        [HttpGet]
        //[Route("players")]
        public IEnumerable<Player> Players()
        {
            return playerService.GetPlayers();
        }
    }
}