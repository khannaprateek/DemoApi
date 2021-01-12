using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Controllers;
using WebApplication.DataApiFactory;

namespace WebApplication.Data
{
    public class UserData : IApi
    {
        private static string URL = "https://5feb08888ede8b0017ff2386.mockapi.io/user/";
        private static  HttpClient _httpclient;
        public UserData(HttpClient httpclient)
        {
            _httpclient = httpclient;
        }
        
        
        public async Task<string> GetRequest()
        {

            using HttpResponseMessage response = await _httpclient.GetAsync(URL);
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;

        }

        
        public async Task<string> GetRequest(int id)
        {

            using HttpResponseMessage response = await _httpclient.GetAsync(URL + id);
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;

        }

        
        public async Task<string> PostRequest(TestModel model)
        {
            var data = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await _httpclient.PostAsync(URL, data);
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            return responseBody;
        }
        
        public async Task<string> PutRequest(int id, TestModel model)
        {
            var data = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using var response = await _httpclient.PutAsJsonAsync(URL + id, data);
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
        
        public async Task<string> DeleteRequest(int id)
        {
            using HttpResponseMessage response = await _httpclient.DeleteAsync(URL + id);
            var responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            return responseBody;
        }
    }
}
