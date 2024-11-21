using MediatR;
using TraversalCoreProject.DataAccessLayer.Concrete;
using TraversalCoreProject.EntityLayer.Concrete;
using TraversalCoreProject.WebUi.CQRS.Commands.GuideComments;

namespace TraversalCoreProject.WebUi.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommands>
    {
        private readonly TraversalContext _context;

        public CreateGuideCommandHandler(TraversalContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateGuideCommands request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new Guide
            {
                Name= request.Name, 
                Description= request.Description,
                Status=true,
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
