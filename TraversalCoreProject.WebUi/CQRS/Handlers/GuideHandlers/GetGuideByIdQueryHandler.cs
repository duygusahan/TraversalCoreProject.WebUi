using MediatR;
using NuGet.Protocol.Plugins;
using TraversalCoreProject.DataAccessLayer.Concrete;
using TraversalCoreProject.WebUi.CQRS.Queries.GuideQueries;
using TraversalCoreProject.WebUi.CQRS.Results.GuideResults;

namespace TraversalCoreProject.WebUi.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuideByIdQuery, GetGuideByIdQueryResult>
    {
        private readonly TraversalContext _context;

        public GetGuideByIdQueryHandler(TraversalContext context)
        {
            _context = context;
        }

        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.id);
            return new GetGuideByIdQueryResult
            {
                GuideId = values.GuideId,
                Description = values.Description,
                Name = values.Name,
            };
        }
    }
}
