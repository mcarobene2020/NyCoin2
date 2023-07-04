using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Linq;

namespace nycoinserver.Models
{
    public enum AccountType
    {
        Corrente = 0,
        Poupança = 1
    }
    public class Bank
    {
        [JsonProperty("idUserBank")]
        public ulong? IdUserBank { get; set; }

        [JsonProperty("idUser")]
        public ulong? IdUser { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("agency")]
        public string Agency { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("operation")]
        public string Operation { get; set; } 

        [JsonProperty("type")]
        public AccountType Type { get; set; }
    }
}
