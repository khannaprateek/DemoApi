using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication.Controllers;
using WebApplication.Data;
using WebApplication.Data.ApiCreator;
using WebApplication.DataApiFactory;

namespace WebApplication.Logic
{
    public class WebLogic : IWebLogic
    {
        private readonly IApi _dataApi;

        public WebLogic(IApiFactory userApiFactory)
        {
            _dataApi = userApiFactory.CreateApi();
        }

        public async Task<string> Get()
        {
            return await _dataApi.GetRequest();
        }
        public async Task<string> Get(int id)
        {
            return await _dataApi.GetRequest(id);
        }

        public async Task<string> Post(TestModel model)
        {
            return await _dataApi.PostRequest(model);
        }

        public async Task<string> Put(int id, TestModel model)
        {
            return await _dataApi.PutRequest(id, model);
        }

        public async Task<string> Delete(int id)
        {
            return await _dataApi.DeleteRequest(id);
        }
    }
}
