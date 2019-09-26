using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parking.Application.Interface;
using Parking.Dto;

namespace Parking.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        private IParkingAppService _parkingAppService { get; set; }

        public ParkingController(IParkingAppService parkingAppService)
        {
            _parkingAppService = parkingAppService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]ParkingDto parking)
        {
            if (_parkingAppService.Create(parking))
                return Ok();
            else
                return BadRequest();
        }



    }
}