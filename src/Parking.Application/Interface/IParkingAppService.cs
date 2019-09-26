using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Application.Interface
{
    public interface IParkingAppService
    {
        bool Create(ParkingDto parking);
    }
}
