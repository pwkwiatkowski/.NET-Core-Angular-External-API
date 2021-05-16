using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestAngular.Models;

namespace TestAngular.TimeZones
{
    public interface IGetSpedifiedTimeZone
    {
        Task<TimeZoneModel> ReturnSpedifiedTimeZoneBasedOnTag();
    }
}
