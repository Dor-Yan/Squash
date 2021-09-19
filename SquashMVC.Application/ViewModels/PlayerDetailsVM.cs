using AutoMapper;
using SquashMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashMVC.Application.ViewModels
{
    public class PlayerDetailsVM : IMapFrom<SquashMVC.Domain.Model.Player>
    {
    
        public int Id { get; set; }

        public string Name { get; set; }
        public string Country { get; set; }

        public string Association { get; set; }

        public int Rank { get; set; }

        public List<SponsorsForListVM> Sponsors { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<SquashMVC.Domain.Model.Player, PlayerDetailsVM>()
                .ForMember(s => s.Sponsors, opt => opt.Ignore());
           
        }
    }
}
