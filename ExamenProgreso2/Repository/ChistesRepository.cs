using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using ExamenProgreso2.Models;
namespace ExamenProgreso2.Repository
{
    public class ChistesRepository
    {
        private HttpClient _httpClient;
        public ChistesRepository() {
            _httpClient = new HttpClient();
        }
        public async Task<IEnumerable<Chiste>> GetCountryListAsync()
        {
            string url = "https://official-joke-api.appspot.com/random_joke";
            string response_json = await _httpClient.GetStringAsync(url);
            Chiste chiste = JsonConvert.DeserializeObject<Chiste>(response_json);
            return new List<Chiste> { chiste };
        }
    }
}
