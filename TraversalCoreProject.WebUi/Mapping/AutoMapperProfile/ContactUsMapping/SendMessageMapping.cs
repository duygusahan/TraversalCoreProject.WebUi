using AutoMapper;
using TraversalCoreProject.DtoLayer.Dtos.ContactDtos;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.WebUi.Mapping.AutoMapperProfile.ContactUsMapping
{
    public class SendMessageMapping:Profile
    {

        public SendMessageMapping()
        {
            CreateMap<SendMessageDto , ContactUs>().ReverseMap();

        }
    }
}
