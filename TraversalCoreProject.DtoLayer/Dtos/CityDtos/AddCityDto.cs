using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalCoreProject.DtoLayer.Dtos.CityDtos
{
    public class AddCityDto
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string CityCountry { get; set; }
    }
}
