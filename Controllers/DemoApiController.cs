using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoApiController : ControllerBase
    {
        public static HttpClient ApiClient { get; set; } = new HttpClient();
        public static string URL = "https://5feb08888ede8b0017ff2386.mockapi.io/user/";
        [HttpGet]
        public async Task<string> GetRequestSample()
        {

            using (HttpResponseMessage response = await ApiClient.GetAsync(URL))
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }

        }

        [HttpGet("{id}")]
        public async Task<string> GetRequestSample(int id)
        {

            using (HttpResponseMessage response = await ApiClient.GetAsync(URL + id))
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }

        }

        [HttpPost]
        public static async Task<string> PostRequestSample(TestModel model)
        {
            var data = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = await ApiClient.PostAsync(URL, data))
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
                return responseBody;
            }
        }
        [HttpPut("{id}")]
        public static async Task<string> PutRequestSample(int id,TestModel model)
        {
            var data = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await ApiClient.PutAsJsonAsync(URL + id, data))
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
        }
        [HttpDelete("{id}")]
        public static async Task<string> DeleteRequestSample(int id)
        {
            using (HttpResponseMessage response = await ApiClient.DeleteAsync(URL + id))
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
                return responseBody;
            }
        }
    }
}
