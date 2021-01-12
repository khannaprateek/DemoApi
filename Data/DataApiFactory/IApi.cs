using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Controllers;

namespace WebApplication.DataApiFactory
{
    public interface IApi
    {
        private static string URL;

        public  Task<string> GetRequest();
        public Task<string> GetRequest(int id);
        public Task<string> PostRequest(TestModel model);
        public  Task<string> PutRequest(int id, TestModel model);
        public  Task<string> DeleteRequest(int id);
    }
}
