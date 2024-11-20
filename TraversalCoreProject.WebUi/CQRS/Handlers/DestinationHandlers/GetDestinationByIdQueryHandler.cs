using DocumentFormat.OpenXml.Office2010.Excel;
using TraversalCoreProject.DataAccessLayer.Concrete;
using TraversalCoreProject.WebUi.CQRS.Queries.DestinationQueries;
using TraversalCoreProject.WebUi.CQRS.Results.DestinationResults;

namespace TraversalCoreProject.WebUi.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly TraversalContext _context;
    

        public GetDestinationByIdQueryHandler(TraversalContext context)
        {
            _context = context;
        }

        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
        {
            var values = _context.Destinations.Find(query.id);
            return new GetDestinationByIdQueryResult
            {
                DestinationId = values.DestinationId,
                City = values.City,
                Daynight = values.DayNight,
                Price=values.Price,
            };
        }
    }
}
