using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace nycoinserver
{
    public enum Endpoint
    {
        Load = 1,
        Create = 2,
        Edit = 3,
        ListItems = 4,
        Delete = 5
    }
    public enum EndpointType
    {
        User = 1,
        DepositOrder = 2,
        WithdrawOrder = 3,
        MyTradeOrder = 4,
        AllMyOrders = 5,
        AllTradeOrders = 6,
        Pair = 7,
        InviteToken = 8,
        ConfirmationToken = 9,
        LastPrice = 10,
        Volume = 11,
        Price = 12,
        Bank = 13,
        MyBank = 14,
        UserInfo = 15,
        Friend = 16,
        UserBusiness = 17,
        BusinessTransactions = 18,
        Payment = 19,
        Deposits = 20,
        Pdv = 21,
        UserPdv = 22,
        Password = 23,
        AdminDeposit = 24,
        AdminWithdraw = 25,
        AdminPassword = 26,
        UserHistory = 27,
        Coin = 28,
        Error = 29,
        Investment = 30,
        InvestmentType = 31,
        AdminUserBalance = 32
    }
    public enum Environment
    {
        Development = 1,
        Master = 2
    }
    public class ApiRequest
    {
        public List<object> data { get; set; }
        public Endpoint endpoint { get; set; }
        public EndpointType endpointType { get; set; }
        public Environment environment { get; set; }
        public string token { get; set; }
        public string adminToken { get; set; }

        public ApiRequest(Endpoint endpoint, EndpointType endpointType,List<object> data = null, string token = null)
        {
            this.endpoint = endpoint;
            this.endpointType = endpointType;
            this.data = data;
            this.token = token;
        }
    }
    public enum ApiResponseStatus
    {
        Success = 1,
        Error = 2,
        TokenInvalid = 3,
        AcessDenied = 4
    }
    public class ApiResponse<Response>
    {
        public ApiResponseStatus status { get; set; }
        public string message { get; set; }
        public Response data { get; set; }
    }
    public class ApiRest
    {
        public static async Task<Response> Request<Request, Response>(string url, Request request)
        {
            try
            {
                var json = JsonConvert.SerializeObject(request);
                HttpClient client = new HttpClient()
                {
                    Timeout = new TimeSpan(0, 0, 30)
                };
                HttpResponseMessage result = null;
                if (request != null)
                {
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    result = await client.PostAsync(url, content);
                }
                else
                {
                    result = await client.GetAsync(url);
                }
                var jsonResposta = result?.Content.ReadAsStringAsync().Result;
                jsonResposta = jsonResposta.Replace("\"NULL\"", "null");
                jsonResposta = jsonResposta.Replace("\"null\"", "null");
                return JsonConvert.DeserializeObject<Response>(jsonResposta);
            }
            catch (HttpRequestException)
            {
                throw new NoInternetException
                {
                    Message = "Não foi possível conectar com o servidor, verifique sua conexão."
                };
            }
            catch(OperationCanceledException)
            {
                throw new NoInternetException
                {
                    Message = "Não foi possível conectar com o servidor, verifique sua conexão."
                };
            }
            catch (Exception e)
            {
                var msg = e.Message;
                var trace = e.StackTrace;
                throw new UnknownException
                {
                    Message = msg + "|" + trace
                };
            }
        }
    }
}
