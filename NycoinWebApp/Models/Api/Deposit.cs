using Newtonsoft.Json;
using System;

namespace nycoinserver.Models
{
    public enum Approval
    {
        Waiting = 0,
        Approval = 1,
        NotApproved = 2
    }
    public class Deposit
    {
        [JsonProperty("idDeposit")]
        public ulong? IdDeposit { get; set; }

        [JsonProperty("idCoin")]
        public ulong? IdCoin { get; set; }

        [JsonProperty("value")]
        public double? Value { get; set; }

        [JsonProperty("waitingForApproval")]
        public Approval? WaitingForApproval { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("userBank")]
        public Bank UserBank { get; set; }

        [JsonProperty("nyBank")]
        public Bank NyBank { get; set; }
    }
}
