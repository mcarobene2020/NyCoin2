using Newtonsoft.Json;

namespace nycoinserver.Models
{
    public enum CoinFiat
    {
        False = 0,
        True = 1
    }
    public class Coin
    {
        [JsonProperty("idCoin")]
        public string IdCoin { get; set; }

        [JsonProperty("nameInSingular")]
        public string NameInSingular { get; set; }

        [JsonProperty("nameInPlural")]
        public string NameInPlural { get; set; }

        [JsonProperty("isFiat")]
        public CoinFiat? IsFiat { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }
}
