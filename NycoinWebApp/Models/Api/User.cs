using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace nycoinserver.Models
{
    public enum LoginType
    {
        Google = 0,
        Facebook = 1,
        NycoinLogin = 2
    }
    public class UserInfo
    {
        [JsonProperty("cpf")]
        public string Cpf { get; set; }

        [JsonProperty("points")]
        public double? Points { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

    }
    public class User
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("loginType")]
        public LoginType LoginType { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("userInfo")]
        public UserInfo UserInfo { get; set; }

    }
}
