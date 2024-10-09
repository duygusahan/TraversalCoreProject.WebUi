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
    public class NewsletterManager : INewsletterService
    {
        private readonly INewsletterDal _newsletterDal;

        public NewsletterManager(INewsletterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }

        public void TDelete(int id)
        {
           _newsletterDal.Delete(id);
        }

        public Newsletter TGetById(int id)
        {
            return _newsletterDal.GetById(id);
        }

        public List<Newsletter> TGetListAll()
        {
            return _newsletterDal.GetListAll();
        }

        public void TInsert(Newsletter entity)
        {
            _newsletterDal.Insert(entity);
        }

        public void TUpdate(Newsletter entity)
        {
            _newsletterDal.Update(entity);
        }
    }
}
