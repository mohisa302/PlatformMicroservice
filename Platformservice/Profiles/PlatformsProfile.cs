using AutoMapper;
using PlatformService.Commands;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
  public class PlatformsProfile : Profile
  {
    public PlatformsProfile()
    {
      // Source -> Target
      CreateMap<Platform, PlatformReadDto>();
      CreateMap<PlatformCreateCommand, Platform>();
    }
  }
}
