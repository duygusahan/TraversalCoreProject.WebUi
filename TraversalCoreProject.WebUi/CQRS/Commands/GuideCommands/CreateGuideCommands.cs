using MediatR;

namespace TraversalCoreProject.WebUi.CQRS.Commands.GuideComments
{
    public class CreateGuideCommands:IRequest
    {
       
        public string Name { get; set; }
       
        public string Description { get; set; }
    }
}
