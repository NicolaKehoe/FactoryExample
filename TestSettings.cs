using System.Data.SqlClient;
using Newtonsoft.Json;
namespace FactoryExample
{
    public class TestSettings //TestSettings class is going to hold the json properties
    {
        [JsonProperty("aut")]
        public string AUT { get; set; }

        [JsonProperty("browserType")]
        public BrowserType BrowserType { get; set; }

    
    }
}