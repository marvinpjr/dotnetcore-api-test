using StatKeeper.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StatKeeper.Api.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        //private readonly StatKeeperContext statKeeperContext;

        public PlayerRepository()
        {
            //this.statKeeperContext = context;
        }

        public Player Create(Player newPlayer)
        {
            //statKeeperContext.Players.Add(newPlayer);
            //statKeeperContext.SaveChanges();
            return newPlayer;
        }

        public bool Delete(Player player)
        {
            //statKeeperContext.Players.Remove(player);
            //return statKeeperContext.SaveChanges() != 0;
            return true;
        }

        public Player GetPlayer(int playerId)
        {
            //return statKeeperContext.Players.SingleOrDefault(p => p.PlayerId == playerId);
            return new Player() { };
        }

        public IEnumerable<Player> GetPlayers()
        {
            //return statKeeperContext.Players.ToList<Player>();
            return new List<Player>() { };
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
