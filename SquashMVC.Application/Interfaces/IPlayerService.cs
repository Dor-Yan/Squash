using SquashMVC.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashMVC.Application.Interfaces
{
    public interface IPlayerService
    {
        ListPlayerForListVM GetAllPlayerForList();

        int AddPlayer(NewPlayerVM player);

        PlayerDetailsVM GetPlayerDetails(int playerId);
    }
}
