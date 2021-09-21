using Core.Utilities.Results.Abstract;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IHouseService
    {
        IDataResult<List<House>> GetAll();
        IDataResult<List<HouseDetailDto>> GetHouseDetails();
        public IDataResult<List<House>> GetByLocation(string location);
        IResult Add(House house);
        IResult Delete(House house);


    }
}
