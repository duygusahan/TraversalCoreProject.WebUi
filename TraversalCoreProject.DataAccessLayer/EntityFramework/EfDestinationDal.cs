using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProject.DataAccessLayer.Abstract;
using TraversalCoreProject.DataAccessLayer.Concrete;
using TraversalCoreProject.DataAccessLayer.Repositories;
using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.DataAccessLayer.EntityFramework
{
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
    

        public EfDestinationDal(TraversalContext context) : base(context)
        {
        }

        public Destination GetDestinationWithGuide(int id)
        {
            using (var context = new TraversalContext())
            {
                return context.Destinations.Where(x => x.DestinationId == id).Include(x => x.Guide).FirstOrDefault();
            }

        }
    }
}
