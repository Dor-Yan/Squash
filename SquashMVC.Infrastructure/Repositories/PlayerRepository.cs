using Microsoft.EntityFrameworkCore;
using SquashMVC.Application.Interfaces;
using SquashMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashMVC.Infrastructure.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly Context _context;

        public PlayerRepository(Context context)
        {
            _context = context;
        }

        public IQueryable<Player> GetAllActivePlayers()
        {
            return _context.Players.Where(p => p.IsActive);
        }

        public void DeletePlayer(int playerId)
        {
            var player = _context.Players.Find(playerId);
            if (player!=null)
            {
                _context.Players.Remove(player);
                _context.SaveChanges();  
            }
        }

        public int AddPlayer(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
            return player.Id;
        }

        public IQueryable<Player> GetPlayersBySexId(int sexId)
        {
            var players = _context.Players.Where(i => i.SexId == sexId);
            return players;
        }

        public IQueryable<Player> GetPlayersByAssociationId(int associationId)
        {
            var players = _context.Players.Where(i => i.AssociationId == associationId);
            return players;
        }

        public IQueryable<Player> GetPlayersByCountryId(int countryId)
        {
            var players = _context.Players.Where(i => i.CountryId == countryId);
            return players;
        }

        public Player GetPlayerById(int playerId)
        {
            var player = _context.Players.FirstOrDefault(i => i.Id == playerId);
            return player;
        } 

        public Player GetPlayer(int playerId)
        {
            var player = _context.Players.Include(p => p.Sponsors).FirstOrDefault(i => i.Id == playerId);
            return player;
        }

        
    }
}
