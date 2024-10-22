using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProject.BusinessLayer.Abstract;
using TraversalCoreProject.DataAccessLayer.Abstract;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.BusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void TDelete(int id)
        {
            _announcementDal.Delete(id);
        }

        public Announcement TGetById(int id)
        {
           return _announcementDal.GetById(id);
        }

        public List<Announcement> TGetListAll()
        {
            return _announcementDal.GetListAll();
        }

        public void TInsert(Announcement entity)
        {
            _announcementDal.Insert(entity);
        }

        public void TUpdate(Announcement entity)
        {
           _announcementDal.Update(entity);
        }
    }
}
