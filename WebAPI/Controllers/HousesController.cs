using Business;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HousesController : ControllerBase
    {
        IHouseService _houseService;
        public HousesController(IHouseService houseService)
        {
            _houseService = houseService;
        }
        [HttpPost("GetAll")]
        public IActionResult GetAll()
        {
            var result = _houseService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Search")]
        public IActionResult Search (string location)
        {
            var result = _houseService.GetByLocation(location);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Add")]
        public IActionResult Add(House house)
        {
            var result = _houseService.Add(house);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Delete")]
        public IActionResult Delete(House house)
        {
            var result = _houseService.Delete(house);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
