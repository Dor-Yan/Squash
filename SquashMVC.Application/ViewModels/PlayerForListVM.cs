 using AutoMapper;
using SquashMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashMVC.Application.ViewModels
{
    public class PlayerForListVM : IMapFrom<SquashMVC.Domain.Model.Player>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public SquashMVC.Domain.Model.Association Association { get; set; }

        public SquashMVC.Domain.Model.Country Country { get; set; }

     //  public SquashMVC.Domain.Model.Sponsors Sponsors { get; set;}

     // public SquashMVC.Domain.Model.SposnorsType SposnorsType { get; set; }

        public int Rank { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<SquashMVC.Domain.Model.Player, PlayerForListVM>();
                //.ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                //.ForMember(d => d.Name, opt => opt.MapFrom(s => s.Name))
                //.ForMember(d => d.Association, opt => opt.MapFrom(s => s.Association))
                //.ForMember(d => d.Rank, opt => opt.MapFrom(s => s.Rank))
                //.ForMember(d => d.Sponsors, opt => opt.MapFrom(s => s.Sponsors));
        }
    }
}
