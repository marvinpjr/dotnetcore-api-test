using StatKeeper.Api.Model;
using StatKeeper.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StatKeeper.Api.Services
{
    public class PlayerService : IPlayerService
    {        
        //private static List<Player> players;
        //private static int counter;
        private readonly IPlayerRepository playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            this.playerRepository = playerRepository;

            //players = new List<Player>()
            //{
            //    new Player(){ Id = 1, FirstName = "Garrett", JerseyNum = 10, LastName = "Palmer" },
            //    new Player(){ Id = 2, FirstName = "Marvin", JerseyNum = 26, LastName = "Palmer" }
            //};
        }

        public Player Create(Player newPlayer)
        {
            //counter++;
            //newPlayer.Id = counter;
            //players.Add(newPlayer);
            //return newPlayer;
            return playerRepository.Create(newPlayer);
        }

        public bool Delete(Player player)
        {
            //var playerToDelete = players.SingleOrDefault(p => p.Id == id);
            //if (playerToDelete == null) return false;
            //int index = players.IndexOf(playerToDelete);
            //players.RemoveAt(index);
            //return true;

            return playerRepository.Delete(player);
        }

        public Player GetPlayer(int id)
        {
            //return players.Single(p => p.Id == id);

            return playerRepository.GetPlayer(id);
        }

        public IEnumerable<Player> GetPlayers()
        {
            return playerRepository.GetPlayers();
        }

        public Player Update(Player player)
        {
            //var playerToUpdate = players.SingleOrDefault(p => p.Id == player.Id);
            //if (playerToUpdate == null) throw new KeyNotFoundException($"No player with id {player.Id} was found. Update failed.");
            //if (!String.IsNullOrWhiteSpace(player.FirstName)) playerToUpdate.FirstName = player.FirstName;
            //if (!String.IsNullOrWhiteSpace(player.LastName)) playerToUpdate.LastName = player.LastName;
            //if (player.JerseyNum != 0) playerToUpdate.JerseyNum = player.JerseyNum;
            //return playerToUpdate;

            return playerRepository.Update(player);
        }
    }

    public interface IPlayerService
    {
        IEnumerable<Player> GetPlayers();
        Player GetPlayer(int id);
        Player Create(Player newPlayer);
        bool Delete(Player player);
        Player Update(Player team);
    }
}
