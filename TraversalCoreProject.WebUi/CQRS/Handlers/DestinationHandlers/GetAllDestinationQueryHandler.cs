using Microsoft.EntityFrameworkCore;
using TraversalCoreProject.DataAccessLayer.Concrete;
using TraversalCoreProject.WebUi.CQRS.Queries.DestinationQueries;
using TraversalCoreProject.WebUi.CQRS.Results.DestinationResults;

namespace TraversalCoreProject.WebUi.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly TraversalContext _context;

        public GetAllDestinationQueryHandler(TraversalContext context)
        {
            _context = context;
        }

        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                capacity = x.Capacity,
                city = x.City,
                daynight = x.DayNight,
                id = x.DestinationId,
                price = x.Price
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
