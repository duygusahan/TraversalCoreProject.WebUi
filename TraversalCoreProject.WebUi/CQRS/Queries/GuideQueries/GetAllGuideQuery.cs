using MediatR;
using TraversalCoreProject.WebUi.CQRS.Results.GuideResults;

namespace TraversalCoreProject.WebUi.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery:IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
