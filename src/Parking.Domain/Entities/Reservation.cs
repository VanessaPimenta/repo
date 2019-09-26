using System;

namespace Parking.Domain.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public int? AssociateId { get; set; }
        public virtual Associate Associate { get; set; }
        public virtual Car Car { get; set; }
        public int CarId { get; set; }
        public virtual Customer Customer { get; set; }
        public int? CustomerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinalDate { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
    }
}