using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.DataAccessLayer.Abstract
{
    public interface IReservationDal:IGenericDal<Reservation>
    {
        List<Reservation> GetListWithReservationByApproveal(int id); 
        List<Reservation> GetListWithReservationByAccepted(int id); 
        List<Reservation> GetListWithReservationByPrevious(int id); 
    }
}
