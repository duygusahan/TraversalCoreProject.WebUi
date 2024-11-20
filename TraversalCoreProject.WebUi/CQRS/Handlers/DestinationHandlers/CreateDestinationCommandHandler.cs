using TraversalCoreProject.DataAccessLayer.Concrete;
using TraversalCoreProject.EntityLayer.Concrete;
using TraversalCoreProject.WebUi.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProject.WebUi.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly TraversalContext _context;

        public CreateDestinationCommandHandler(TraversalContext context)
        {
            _context = context;
        }

        public void Handle(CreateDestinationCommand command)
        {
            _context.Destinations.Add(new Destination
            {
                City = command.City,
                Price = command.Price,
                Status = true,
                DayNight = command.DayNight,
                Capacity = command.Capacity
            });
            _context.SaveChanges();
        }
    }
}
