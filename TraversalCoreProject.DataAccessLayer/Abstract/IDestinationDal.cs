using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.DataAccessLayer.Abstract
{
    public interface IDestinationDal:IGenericDal<Destination>
    {
        public Destination GetDestinationWithGuide(int id);

        List<Destination> GetLast4Destination();
    }
}
