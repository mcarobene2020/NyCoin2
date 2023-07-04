using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nycoinserver.Models
{
    public enum Environment
    {
        Development = 1,            //ativo
        Production = 2              //ativo
    }
    public class Request
    {
        [JsonProperty("data")]
        public List<object> Data { get; set; }
        [JsonProperty("environment")]
        public Environment Environment { get; set; } = Environment.Development;
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonIgnore]
        public string Url { get; set; }
    }
}
