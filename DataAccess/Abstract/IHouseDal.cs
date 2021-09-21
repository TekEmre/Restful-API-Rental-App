﻿using Core;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IHouseDal:IEntityRepository<House>
    {
        List<HouseDetailDto> GetHouseDetails();
    }
}
