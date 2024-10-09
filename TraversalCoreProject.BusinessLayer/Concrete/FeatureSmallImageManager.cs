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
    public class FeatureSmallImageManager : IFeatureSmallImagesService
    {
        private readonly IFeatureSmallImagesDal _featureSmallImagesDal;

        public FeatureSmallImageManager(IFeatureSmallImagesDal featureSmallImagesDal)
        {
            _featureSmallImagesDal = featureSmallImagesDal;
        }

        public void TDelete(int id)
        {
           _featureSmallImagesDal.Delete(id);
        }

        public FeatureSmallImages TGetById(int id)
        {
            return _featureSmallImagesDal.GetById(id);
        }

        public List<FeatureSmallImages> TGetListAll()
        {
            return _featureSmallImagesDal.GetListAll();
        }

        public void TInsert(FeatureSmallImages entity)
        {
            _featureSmallImagesDal.Insert(entity);
        }

        public void TUpdate(FeatureSmallImages entity)
        {
           _featureSmallImagesDal.Update(entity);
        }
    }
}
