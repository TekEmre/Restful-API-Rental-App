using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HouseManager : IHouseService
    {
        IHouseDal _houseDal;
        public HouseManager(IHouseDal houseDal)
        {
            _houseDal = houseDal;
        }
        public IResult Add(House house)
        {
            _houseDal.Add(house);
            return new SuccessResult(Messages.HouseAdded);
        }
        public IResult Delete(House house)
        {
            _houseDal.Delete(house);
            return new SuccessResult(Messages.HouseDeleted);
        }

        public IDataResult<List<House>> GetAll()
        {
            return new SuccessDataResult<List<House>>(_houseDal.GetAll(), Messages.HousesListed);
        }
        public IDataResult<List<House>> GetByLocation(string location)
        {
            return new SuccessDataResult<List<House>>(_houseDal.GetAll(p => p.HouseLocation == location), Messages.HouseFound);
        }

        public IDataResult<List<HouseDetailDto>> GetHouseDetails()
        {
            return new SuccessDataResult<List<HouseDetailDto>>(_houseDal.GetHouseDetails());
        }
    }
}
