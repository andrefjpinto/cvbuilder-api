using AutoMapper;
using cvbuilder_api.Models;
using cvbuilder_api.ViewModels;

namespace cvbuilder_api.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}