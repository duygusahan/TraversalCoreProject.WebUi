using AutoMapper;
using TraversalCoreProject.DtoLayer.Dtos.AppUserDtos;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.WebUi.Mapping.AutoMapperProfile.RegisterMapping
{
    public class RegisterMapping:Profile
    {
        public RegisterMapping()
        {
                CreateMap<AppUserRegisterDto , AppUser>().ReverseMap();

        }
    }
}
