using Newtonsoft.Json;

namespace nycoinserver.Models
{
    public class Pair 
    {
        [JsonProperty("idPair")]
        public double? IdPair { get; set; }

        [JsonProperty("idCoin1")]
        public int? IdCoin1 { get; set; }

        [JsonProperty("idCoin2")]
        public int? IdCoin2 { get; set; }

        [JsonProperty("coinOne")]
        public Coin CoinOne { get; set; }

        [JsonProperty("coinTwo")]
        public Coin CoinTwo { get; set; }
    }
}
