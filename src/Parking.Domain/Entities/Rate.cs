using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain
{
    public class Rate
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Descpription { get; set; }
        public double DiaryValue { get; set; }
        public double OvernightValue { get; set; }
        public double FractionValue { get; set; }

    }
}
