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
    public class ContactUsManager : IContactUsService
    {
        private readonly IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void TDelete(int id)
        {
           _contactUsDal.Delete(id);
        }

        public ContactUs TGetById(int id)
        {
           return _contactUsDal.GetById(id);
        }

        

        public List<ContactUs> TGetListAll()
        {
            return _contactUsDal.GetListAll();
        }

        public void TInsert(ContactUs entity)
        {
            _contactUsDal.Insert(entity);
        }

        public void TUpdate(ContactUs entity)
        {
           _contactUsDal.Update(entity);
        }
    }
}
