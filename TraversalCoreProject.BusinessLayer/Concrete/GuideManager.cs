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
    public class GuideManager : IGuideService
    {
        private readonly IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void TChangeStatusToFalse(int id)
        {
            _guideDal.ChangeStatusToFalse(id);
          
        }

        public void TChangeStatusToTrue(int id)
        {
            _guideDal.ChangeStatusToTrue(id);
        }

        public void TDelete(int id)
        {
            _guideDal.Delete(id);
        }

        public Guide TGetById(int id)
        {
            return _guideDal.GetById(id);
        }

        public List<Guide> TGetListAll()
        {
           return _guideDal.GetListAll();
        }

        public void TInsert(Guide entity)
        {
            _guideDal.Insert(entity);
        }

        public void TUpdate(Guide entity)
        {
           _guideDal.Update(entity);
        }
    }
}
