using Parking.Domain.Context;
using Parking.Domain.Extensions;
using Parking.Domain.Interface;
using Parking.Dto;
using Parking.Infr;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain
{
    public class ParkingDomainService : IParkingDomainService
    {
        private ParkingDataContext _context { get; set; }
        private ParkingReadRepository _parkingReadRepository { get; set; }
        

        public ParkingDomainService(ParkingDataContext context,
                                    ParkingReadRepository parkingReadRespository)
        {
            _context = context;
            _parkingReadRepository = parkingReadRespository;
        }

        public bool Create(ParkingDto parkingDto)
        {
            try
            {
                _context.Parkings.Add(new Parking()
                {
                    Address = parkingDto.Address,
                    Description = parkingDto.Description,
                    Document = parkingDto.Document,
                    Phone = parkingDto.Phone
                }) ;

                _context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var parking =/*_context.Parking.Find(id);*/
                    _parkingReadRepository.GetById(id);

                if (parking != null)
                {
                    _context.Parkings.Remove(parking.DtoToEntity());
                    _context.SaveChanges();
                    return true;
                }

                return false;
            }

            catch
            {
                return false;
            }

        }

    }
}
