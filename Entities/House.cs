using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class House : IEntity
    {
        [Key]      
        public string HousePrice { get; set; }
        public string HouseLocation { get; set; }
        public int HouseSqft { get; set; }
        public string HouseImage { get; set; }
    }
}
