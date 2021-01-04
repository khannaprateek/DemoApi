using Newtonsoft.Json;

namespace WebApplication.Controllers
{
    public class TestModel
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("phone no")]
        public int phoneNo { get; set; }
    }
}
