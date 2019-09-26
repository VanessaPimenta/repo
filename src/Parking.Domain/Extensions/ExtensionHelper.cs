using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Extensions
{
    public static class ExtensionHelper
    {
        public static Parking DtoToEntity(this ParkingDto parkingDto)
        {
            return new Parking()
            {
                Address = parkingDto.Address,
                Description = parkingDto.Description,
                Document = parkingDto.Document,
                Phone = parkingDto.Phone
            };
        }

        public static ParkingDto EntityToDto(this Parking parking)
        {
            return new ParkingDto()
            {
                Address = parking.Address,
                Description = parking.Description,
                Document = parking.Document,
                Phone = parking.Phone
            };
        }
    }
}