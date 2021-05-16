using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestAngular.Models;

namespace TestAngular.Services
{
    public interface ITimeZoneService
    {
        Task<TimeZoneModel> GetSpecifiedTimeZoneBasedOnUrl();
    }
}
