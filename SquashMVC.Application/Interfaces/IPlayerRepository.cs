using SquashMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashMVC.Application.Interfaces
{
    public interface IPlayerRepository
    {
        
        void DeletePlayer(int playerId);


        int AddPlayer(Player player);


        IQueryable<Player> GetPlayersBySexId(int sexId);


        IQueryable<Player> GetPlayersByAssociationId(int associationId);


        IQueryable<Player> GetPlayersByCountryId(int countryId);


        Player GetPlayerById(int playerID);
    }
}
