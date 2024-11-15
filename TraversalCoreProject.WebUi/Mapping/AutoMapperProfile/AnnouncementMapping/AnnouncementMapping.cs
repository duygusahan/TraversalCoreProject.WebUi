using AutoMapper;
using TraversalCoreProject.DtoLayer.Dtos.AnnouncementDtos;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.WebUi.Mapping.AutoMapperProfile.AnnouncementMapping
{
    public class AnnouncementMapping : Profile
    {
        public AnnouncementMapping()
        {

            CreateMap<Announcement, AddAnnouncementDto>().ReverseMap();
            CreateMap<Announcement, ResultAnnouncementDto>().ReverseMap();
            CreateMap<Announcement, UpdateAnnouncementDto>().ReverseMap();

        }
    }
}
