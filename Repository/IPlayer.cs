using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace dotnetRPG.Repository
{
    public interface IPlayer
    {
        Task<List<Player>> GetPlayers();

        Task<Player> GetPlayer(Guid Id);

        Task CreatePlayer(Player player);

        Task UpdatePlayer(Guid Id, Player player);

        Task DeletePlayer(Guid Id);
    }
}