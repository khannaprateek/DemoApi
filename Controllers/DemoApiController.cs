using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WebApplication.Logic;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoApiController : ControllerBase
    {
        private readonly IWebLogic _webLogic;
        
        public DemoApiController(IWebLogic webLogic)
        {
            _webLogic = webLogic;

        }

        [HttpGet]
        public Task<string> GetAllUsers()
        {
            return _webLogic.Get();
        }

        [HttpGet("{id}")]
        public async Task<string> GetThisUser(int id)
        {
            return await _webLogic.Get(id);

        }

        [HttpPost]
        public async Task<string> AddNewUser(TestModel model)
        {
            return await _webLogic.Post(model);
        }
        [HttpPut("{id}")]
        public async Task<string> UpdateThisUser(int id,TestModel model)
        {
            return await _webLogic.Put(id, model);
        }
        [HttpDelete("{id}")]
        public async Task<string> DeleteThisUser(int id)
        {
            return await _webLogic.Delete(id);
        }
    }
}
