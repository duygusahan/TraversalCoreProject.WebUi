using AutoMapper;
using TraversalCoreProject.DtoLayer.Dtos.AppUserDtos;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.WebUi.Mapping.AutoMapperProfile.LoginMapping
{
    public class LoginMapping:Profile
    {
        public LoginMapping()
        {
            CreateMap<AppUserLoginDto, AppUser>().ReverseMap();
        }
    }
}
