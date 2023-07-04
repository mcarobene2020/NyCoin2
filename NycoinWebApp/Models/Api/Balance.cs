using Newtonsoft.Json;

namespace nycoinserver.Models
{
    public class Balance
    {
        [JsonProperty("idCoin")]
        public ulong? IdCoin { get; set; }

        [JsonProperty("balance")]
        public double? UserBalance { get; set; }

        [JsonProperty("coinName")]
        public string CoinName { get; set; }
    }
}