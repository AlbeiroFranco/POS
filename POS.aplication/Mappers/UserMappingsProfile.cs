using AutoMapper;
using POS.Aplication.Dtos.User.Request;
using POS.Domain.Entities;

namespace POS.Aplication.Mappers
{
    public class UserMappingsProfile : Profile
    {
        public UserMappingsProfile()
        {
            CreateMap<UserRequestDto, User>();
            CreateMap<TokenRequestDto, User>();
        }
    }
}
