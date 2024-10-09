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
    public class About2Manager : IAbout2Service
    {
        private readonly IAbout2Dal _about2Dal;

        public About2Manager(IAbout2Dal about2Dal)
        {
            _about2Dal = about2Dal;
        }

        public void TDelete(int id)
        {
            _about2Dal.Delete(id);
        }

        public About2 TGetById(int id)
        {
            return _about2Dal.GetById(id);
        }

        public List<About2> TGetListAll()
        {
           return _about2Dal.GetListAll();
        }

        public void TInsert(About2 entity)
        {
           _about2Dal.Insert(entity);
        }

        public void TUpdate(About2 entity)
        {
           _about2Dal.Update(entity);
        }
    }
}
