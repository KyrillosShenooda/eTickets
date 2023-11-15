using AutoMapper;
using eTickets.DAL.Entities;
using eTickets.Pl.Models;

namespace eTickets.Pl.Mapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Actor, ActorViewModel>().ReverseMap();
            CreateMap<Producer, ProducerViewModel>().ReverseMap();
        }
    }
}
