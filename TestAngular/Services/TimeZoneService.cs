using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestAngular.Models;
using TestAngular.TimeZones;

namespace TestAngular.Services
{
    public class TimeZoneService : ITimeZoneService
    {
        private readonly IGetSpedifiedTimeZone _getSpecifiedTimeZone;
        public TimeZoneService(IGetSpedifiedTimeZone getSpedifiedTimeZone)
        {
            _getSpecifiedTimeZone = getSpedifiedTimeZone;
        }
        public async Task<TimeZoneModel> GetSpecifiedTimeZoneBasedOnUrl()
        {
            return await _getSpecifiedTimeZone.ReturnSpedifiedTimeZoneBasedOnTag();
        }
    }
}
