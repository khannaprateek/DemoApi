using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication.DataApiFactory;

namespace WebApplication.Data.ApiCreator
{
    public class UserApiFactory:IApiFactory
    {
        private readonly HttpClient _httpClient;

        public UserApiFactory(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }
        public IApi CreateApi()
        {
            return new UserData(_httpClient);
        }
    }
}
