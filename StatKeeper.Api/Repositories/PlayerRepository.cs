using StatKeeper.Api.EntityFramework;
using StatKeeper.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StatKeeper.Api.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly StatKeeperContext statKeeperContext;

        public PlayerRepository(StatKeeperContext context)
        {
            this.statKeeperContext = context;
        }

        public Player Create(Player newPlayer)
        {
            statKeeperContext.Players.Add(newPlayer);
            statKeeperContext.SaveChanges();
            return newPlayer;
        }

        public bool Delete(Player player)
        {
            statKeeperContext.Players.Remove(player);
            return statKeeperContext.SaveChanges() != 0;
        }

        public Player GetPlayer(int playerId)
        {
            return statKeeperContext.Players.SingleOrDefault(p => p.PlayerId == playerId);
        }

        public IEnumerable<Player> GetPlayers()
        {
            return statKeeperContext.Players.ToList<Player>();
        }

        public Player Update(Player team)
        {
            throw new NotImplementedException();
        }
    }

    public interface IPlayerRepository
    {
        Player Create(Player newPlayer);
        bool Delete(Player player);
        Player GetPlayer(int playerId);
        IEnumerable<Player> GetPlayers();
        Player Update(Player team);
    }
}
