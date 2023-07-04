using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nycoinserver.Models
{
    public enum ReturnStatus
    {
        Success = 1,
        Error = 2,
        TokenInvalid = 3,
        AccessDenied = 4
    }
    public class Response<ReturnType>
    {
        public const string DefaultErrorMessage = "Erro interno do servidor, "
                + "nossa equipe já foi acionada para resolver este problema, "
                + "pedimos desculpas pelo inconveniente.";
        [JsonProperty("status")]
        public ReturnStatus Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public ReturnType Data { get; set; }
    }
}
