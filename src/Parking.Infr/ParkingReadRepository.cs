using Parking.Domain.Context;
using Parking.Dto;
using Parking.Infr.Interface;
using System;
using System.Collections.Generic;

namespace Parking.Infr
{
    public class ParkingReadRepository : IParkingReadRepository
    {
        private ParkingDataContext _context { get; set; }

        public ParkingReadRepository(ParkingDataContext context)
        {
            _context = context;
        }

        public List<ParkingDto> GetAll()
        {
            return _context.Parkings
               .where(x => x.Id == id)
               .Select(x => new ParkingDto
               {
                   Address = x.Address,
                   Description = x.Description,
                   Document = x.Document,
                   Phone    = x.Phone
               }).FirstOrDefault();
                    
        }

        public ParkingDto GetById(int id)
        {
            return _context.Parking
                .Where(x => x.Id == id)
                .Select(x => new ParkingDto
                {
                    Address = x.Address,
                    Description = x.Description,
                    Document = x.Document,
                    Phone = x.Phone
                }).FirstOrDefault();
        }

        public List<ParkingDto> GetAllWithDapper()
        {
            var ret = new List<ParkingDto>();

            using (var connection = _context.Database.GetDbConnection())
            {
                ret = connection.Query<ParkingDto>("select Id, description, Document, Address" +
                    "from Parking ");
            }
        }



    }
}

