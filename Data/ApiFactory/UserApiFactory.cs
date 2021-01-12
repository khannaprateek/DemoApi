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
        public IApi CreateApi(HttpClient httpClient)
        {
            return new UserData(httpClient);
        }
    }
}
