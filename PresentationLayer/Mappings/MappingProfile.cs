using AutoMapper;
using DomainLayer.Entities;
using PresentationLayer.Models;

namespace PresentationLayer.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductViewModel, Product>().ReverseMap();
        }
    }
}
