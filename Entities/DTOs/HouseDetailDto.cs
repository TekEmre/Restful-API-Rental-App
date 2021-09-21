using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class HouseDetailDto:IDto
    {
        public string HousePrice { get; set; }
        public string HouseLocation { get; set; }
        public int HouseSqft { get; set; }
        public string HouseImage { get; set; }
    }
}
