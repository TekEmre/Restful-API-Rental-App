using Core.EntityFramework;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfHouseDal : EfEntityRepositoryBase<House, DatabaseContext>,IHouseDal
    {
        public List<HouseDetailDto> GetHouseDetails()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from u in context.Houses                                                        
                             select new HouseDetailDto
                             {                               
                                 HousePrice=u.HousePrice,
                                 HouseLocation=u.HouseLocation,
                                 HouseSqft=u.HouseSqft,
                                 HouseImage=u.HouseImage                                                               
                             };
                return result.ToList();
            }
        }
    }
}
