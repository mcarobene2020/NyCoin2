using Newtonsoft.Json;
using System;

namespace nycoinserver.Models
{
    public class Withdraw
    {
        [JsonProperty("idWithdraw")]
        public ulong? IdWithdraw { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("idCoin")]
        public ulong? IdCoin { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("value")]
        public double? Value { get; set; }

        [JsonProperty("waitingForApproval")]
        public Approval? WaitingForApproval { get; set; }

        [JsonProperty("userBank")]
        public Bank UserBank { get; set; }

        [JsonProperty("nyBank")]
        public Bank NyBank { get; set; }
    }
}
