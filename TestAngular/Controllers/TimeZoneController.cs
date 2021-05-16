using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TestAngular.Models;
using TestAngular.Services;

namespace TestAngular.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeZoneController : ControllerBase
    {
        private readonly ITimeZoneService _timeZoneService;
        public TimeZoneController(ITimeZoneService timeZoneServices)
        {
            _timeZoneService = timeZoneServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetTimeZone()
        {
            try
            {
                var result = await _timeZoneService.GetSpecifiedTimeZoneBasedOnUrl();

                return Ok(result);
            }
            catch (Exception)
            {
                return NotFound();
                //throw;
            }
        }
    }
}
