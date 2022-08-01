using AutoMapper;
using Mongo.CertificationProject.API.Dtos;
using Mongo.CertificationProject.API.Entities;

namespace Mongo.CertificationProject.API
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<CityDto, City>()
                .ForMember(dst => dst.Id, src => src.MapFrom(a => a.Name))
                .ForMember(dst => dst.Position, src => src.MapFrom(a => a.Location))
               .ReverseMap();

            CreateMap<PlaneDto, Plane>()
                .ForMember(dst => dst.Id, src => src.MapFrom(a => a.Callsign))
                .ReverseMap();

            CreateMap<CargoDto, Cargo>()
             .ReverseMap();
        }
    }
}
