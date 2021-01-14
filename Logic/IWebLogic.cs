using System.Threading.Tasks;
using WebApplication.Controllers;

namespace WebApplication.Logic
{
    public interface IWebLogic
    {
        Task<string> Delete(int id);
        Task<string> Get();
        Task<string> Get(int id);
        Task<string> Post(TestModel model);
        Task<string> Put(int id, TestModel model);
    }
}