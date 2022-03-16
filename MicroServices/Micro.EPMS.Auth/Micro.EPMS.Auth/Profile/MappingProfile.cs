using AutoMapper;
using Login.DomainModels.Models;
using Micro.EPMS.Auth.ViewModels;

namespace Micro.EPMS.Auth
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, LoginResponse>(); 
        }
    }
}
