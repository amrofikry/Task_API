

using AutoMapper;
using RepostaryPattren.Api.Dtos;
using RepostaryPattren.Core.Identity;

namespace RepostaryPattren.Api.Infrastructure
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {

            CreateMap< User, GetUserDto>()
       .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
       .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
       .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
       .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
       .ForMember(dest => dest.certificates, opt => opt.MapFrom(src => src.certificates))
      
       .ReverseMap();



            CreateMap<UserDto, User>()
   .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
   .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
   .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
   .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
   //.ForMember(dest => dest.certificates, opt => opt.MapFrom(src => src.certificates))

   .ReverseMap();

        }
    }
}