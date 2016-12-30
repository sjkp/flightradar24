using Newtonsoft.Json;
using sjkp.flightradar24.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace sjkp.flightradar24.api
{
    public class FlightRadar24Client
    {
        private readonly HttpClient httpClient;

        public FlightRadar24Client()
        {
            httpClient = new HttpClient();
        }
        public async Task<SearchResponse> Search(string query, int limit = 16)
        {
            return JsonConvert.DeserializeObject<SearchResponse>(await httpClient.GetStringAsync($"https://www.flightradar24.com/v1/search/web/find?query={query}&limit={limit}"));
        }

        public async Task<object> LiveData(string id)
        {
            var now = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            var url = $"https://data-live.flightradar24.com/zones/fcgi/feed.js?faa=1&mlat=1&flarm=1&adsb=1&gnd=1&air=1&vehicles=1&estimated=1&maxage=60&gliders=1&time={now}&filter_info=1&selected={id}&ems=1&limit=0";
            return await httpClient.GetStringAsync(url);
            
        }

        public async Task<FlightDetailsResponse> Details(string flightId)
        {
            var url = $"https://data-live.flightradar24.com/clickhandler/?version=1.5&flight={flightId}";

            return JsonConvert.DeserializeObject<FlightDetailsResponse>(await httpClient.GetStringAsync(url));
        }
    }
}
