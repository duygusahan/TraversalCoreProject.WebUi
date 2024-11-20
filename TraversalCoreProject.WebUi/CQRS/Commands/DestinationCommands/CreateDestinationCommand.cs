using TraversalCoreProject.EntityLayer.Concrete;

namespace TraversalCoreProject.WebUi.CQRS.Commands.DestinationCommands
{
    public class CreateDestinationCommand
    {
        public int DestinationId { get; set; }
        public string City { get; set; }

        public string DayNight { get; set; }
        public string Price { get; set; }
      
    
        public int Capacity { get; set; }
     
       
        
       
    }
}
