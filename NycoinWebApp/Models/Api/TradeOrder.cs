using Newtonsoft.Json;
using System;

namespace nycoinserver.Models
{
    public enum TradeType
    {
        BuyOrder = 0,
        SellOrder = 1,
        ExecOrder = 2
    }
    public enum TradeExecutedWay
    {
        LimitedOrder = 0,
        MarketOrder = 1
    }
    public class TradeOrder
    {
        [JsonProperty("idTradeOrder")]
        public double? IdTradeOrder { get; set; }

        [JsonProperty("idPair")]
        public double? IdPair { get; set; }

        [JsonProperty("type")]
        public TradeType Type { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("executedWay")]
        public TradeExecutedWay? ExecutedWay { get; set; }

        [JsonProperty("total")]
        public double? Total { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("barSize")]
        public double BarSize { get; set; }
    }
}
