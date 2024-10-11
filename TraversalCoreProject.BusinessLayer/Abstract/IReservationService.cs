using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.BusinessLayer.Abstract
{
    public interface IReservationService:IGenericService<Reservation>
    {
       
        List<Reservation> TGetListWithReservationByApproveal(int id);
        List<Reservation> TGetListWithReservationByAccepted(int id);
        List<Reservation> TGetListWithReservationByPrevious(int id);
    }
}
