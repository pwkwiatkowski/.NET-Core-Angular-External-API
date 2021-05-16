using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using TestAngular.Models;

namespace TestAngular.TimeZones
{
    public class GetSpedifiedTimeZone : IGetSpedifiedTimeZone
    {
        public GetSpedifiedTimeZone(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public async Task<TimeZoneModel> ReturnSpedifiedTimeZoneBasedOnTag()
        {
            using var client = new HttpClient();

            //var url = new Uri($"https://worldtimeapi.org/api/timezone/Europe/Warsaw");
            string uri = Configuration.GetValue<string>("MetaAPI");

            //var response = await client.GetAsync(url);
            var response = await client.GetAsync(uri);

            return await response.Content.ReadFromJsonAsync<TimeZoneModel>();
        }
    }
}