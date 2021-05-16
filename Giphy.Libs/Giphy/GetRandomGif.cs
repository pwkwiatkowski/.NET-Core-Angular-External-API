using Giphy.Libs.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Giphy.Libs.Giphy
{
    public class GetRandomGif : IGetRandomGif
    {
        //on ma inaczej
        //private static readonly HttpClient Client = new HttpClient();

        //public async Task<GiphyModel> ReturnRandomGifBasedOnTag(string searchCritera)
        //{
        //    const string giphyKey = "PJNlhf9YNC2AeHQSgn9kYkj6mj7alpFP";

        //    var url = new Uri($"http://api.giphy.com/v1/gifs/search?api_key={giphyKey}&q={searchCritera}&limit=1");

        //    var response = await Client.GetAsync(url);

        //    string json;
        //    using (var content = response.Content)
        //    {
        //        json = await content.ReadAsStringAsync();
        //    }

        //    return JsonConvert.DeserializeObject<GiphyModel>(json);
        //}

        public async Task<GiphyModel> ReturnRandomGifBasedOnTag(string searchCritera)
        {
            const string giphyKey = "";

            using (var client = new HttpClient())
            {
                var url = new Uri($"http://api.giphy.com/v1/gifs/search?api_key={giphyKey}&q={searchCritera}&limit=1");

                var response = await client.GetAsync(url);

                string json;
                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }

                return JsonConvert.DeserializeObject<GiphyModel>(json);
            }
        }
    }
}