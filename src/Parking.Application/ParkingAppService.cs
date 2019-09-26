using Parking.Application.Interface;
using Parking.Domain.Interface;
using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Application
{
    public class ParkingAppService : IParkingAppService
    {
        private IParkingDomainService _parkingDomainService { get; set; }

        public ParkingAppService(IParkingDomainService parkingDomainService)
        {
            _parkingDomainService = parkingDomainService;
        }

        public bool Create(ParkingDto parking)
        {
            return _parkingDomainService.Create(parking);
        }

        public bool Delete(ParkingDto parking)
        {
            return _parkingDomainService.Create(parking);
        }
    }
}
