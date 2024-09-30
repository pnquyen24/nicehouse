using AutoMapper;
using NiceHouse.DTOs;

namespace NiceHouse
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.Products, ProductsDTO>().ReverseMap();
            CreateMap<Models.Images, ImagesDTO>().ReverseMap();
        }
    }
}
