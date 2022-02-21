using AutoMapper;
using Microservices_PlatformService.Models;
using Microservices_PlatformService.Dtos;
namespace Microservices_PlatformService.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            //source to target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}