using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalCoreProject.DtoLayer.Dtos.DestinationDtos
{
    public class AddDestinationDto
    {
        public string TourName { get; set; }
        public string DayNight { get; set; }
        public string Price { get; set; }
        public int Capacity { get; set; }
    }
}
