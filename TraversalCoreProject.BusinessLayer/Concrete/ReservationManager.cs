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
    public class ReservationManager : IReservationService
    {
        private readonly IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        

        public void TDelete(int id)
        {
           _reservationDal.Delete(id);
        }

        public Reservation TGetById(int id)
        {
            return _reservationDal.GetById(id);
        }

        public List<Reservation> TGetListAll()
        {
            return _reservationDal.GetListAll();
        }

        public List<Reservation> TGetListWithReservationByAccepted(int id)
        {
            return _reservationDal.GetListWithReservationByAccepted(id);
        }

        public List<Reservation> TGetListWithReservationByApproveal(int id)
        {
            return _reservationDal.GetListWithReservationByApproveal(id);
        }

        public List<Reservation> TGetListWithReservationByPrevious(int id)
        {
            return _reservationDal.GetListWithReservationByPrevious(id);
        }

        public void TInsert(Reservation entity)
        {
           _reservationDal.Insert(entity);
        }

        public void TUpdate(Reservation entity)
        {
            _reservationDal.Update(entity);
        }
    }
}
