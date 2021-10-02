using AutoMapper;
using AutoMapper.QueryableExtensions;
using SquashMVC.Application.Interfaces;
using SquashMVC.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashMVC.Application.Services
{  
    public class PlayerService : IPlayerService
    {

        private readonly IPlayerRepository _playerRepo;
        private readonly IMapper _mapper;

        public PlayerService(IPlayerRepository playerRepo, IMapper mapper)
        {
            _mapper = mapper;
            _playerRepo = playerRepo;
        }
        public int AddPlayer(NewPlayerVM player)
        {
            throw new NotImplementedException();
        }

        public ListPlayerForListVM GetAllPlayerForList()
        {
            var players = _playerRepo.GetAllActivePlayers()
                .ProjectTo<PlayerForListVM>(_mapper.ConfigurationProvider).ToList();

            var playerList = new ListPlayerForListVM()
            {
                Players = players,
                count = players.Count

            };

            return playerList;
        }

        public PlayerDetailsVM GetPlayerDetails(int id)
        {
            var player = _playerRepo.GetPlayer(id);
            var playerVm = _mapper.Map<PlayerDetailsVM>(player);
            
            playerVm.Sponsors = new List<SponsorsForListVM>();

            foreach (var sponsors in    player.Sponsors)
            {
                var spons = new SponsorsForListVM()
                {
                    Id = sponsors.Id,
                    Name = sponsors.SponsorsName,
                    Type = sponsors.SposnorsType,
                };

                playerVm.Sponsors.Add(spons);
            }

            return playerVm;
        }
    }
}
