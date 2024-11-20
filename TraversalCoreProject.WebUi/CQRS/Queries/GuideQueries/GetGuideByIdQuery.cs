using MediatR;
using TraversalCoreProject.WebUi.CQRS.Results.GuideResults;

namespace TraversalCoreProject.WebUi.CQRS.Queries.GuideQueries
{
    public class GetGuideByIdQuery:IRequest<GetGuideByIdQueryResult>
    {
        public int id { get; set; }

        public GetGuideByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
