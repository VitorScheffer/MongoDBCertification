using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Mongo.CertificationProject.API.DAL;
using Mongo.CertificationProject.API.Dtos;

namespace Mongo.CertificationProject.API.Services
{
    public class CityService
    {
        private readonly CityRepository cityRepository;
        private readonly IMapper mapper;

        public CityService(CityRepository cityRepository, IMapper mapper)
        {
            this.cityRepository = cityRepository;
            this.mapper = mapper;
        }

        public async Task<List<CityDto>> GetAllAsync()
        {
            return mapper.Map<List<CityDto>>(await cityRepository.GetAllAsync());
        }

        public async Task<CityDto> GetByIdAsync(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return null;
            }
            return mapper.Map<CityDto>(await cityRepository.GetByIdAsync(id));
        }

        public async Task<dynamic> GetByIdNearbyCitiesSortedByNearestFirst(string id, int count)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return null;
            }

            var city = await GetByIdAsync(id);

            if (city == null)
            {
                return null;
            }

            return new
            {
                neighbors = mapper.Map<List<CityDto>>(await cityRepository.GetNearbyCitiesSortedByNearestFirst(city.Location[0], city.Location[1], count))
            };
        }
    }
}
