using MediatR;
using Microsoft.EntityFrameworkCore;
using TraversalCoreProject.DataAccessLayer.Concrete;
using TraversalCoreProject.WebUi.CQRS.Queries.GuideQueries;
using TraversalCoreProject.WebUi.CQRS.Results.DestinationResults;
using TraversalCoreProject.WebUi.CQRS.Results.GuideResults;

namespace TraversalCoreProject.WebUi.CQRS.Handlers.GuideHandlers
{
    public class GetAllGuideQueryHandler : IRequestHandler<GetAllGuideQuery, List<GetAllGuideQueryResult>>
    {
        private readonly TraversalContext _context;

        public GetAllGuideQueryHandler(TraversalContext context)
        {
            _context = context;
        }

        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _context.Guides.Select(x => new GetAllGuideQueryResult
            {
                Description = x.Description,
                GuideId = x.GuideId,
                ImageUrl = x.ImageUrl,
                Name = x.Name
            }).AsNoTracking().ToListAsync();
        }
    }
}
