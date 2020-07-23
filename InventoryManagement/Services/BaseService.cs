using InventoryManagement.Models.Movies;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace InventoryManagement.Services
{
    public class BaseService
    {
        public async Task<T> GetAPIResult<T>(string baseURL, string apiCall)
        {

            using (var httpClient = new HttpClient())
            {


                httpClient.BaseAddress = new Uri(baseURL);

                var response = await httpClient.GetAsync(apiCall);

                response.EnsureSuccessStatusCode();

                return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
            }
        }

    }
}
