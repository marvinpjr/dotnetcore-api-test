using StatsKeeper.Api.EntityFramework;
using StatsKeeper.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StatsKeeper.Api.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly StatKeeperContext statKeeperContext;

        public PlayerRepository()
        {
            this.statKeeperContext = new StatKeeperContext();
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
            return statKeeperContext.Players.SingleOrDefault(p => p.Id == playerId);
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
