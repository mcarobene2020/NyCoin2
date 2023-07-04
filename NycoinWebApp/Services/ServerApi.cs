using nycoinserver.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace nycoinserver
{
    #region Exceptions
    public class NoInternetException : Exception
    {
        public new string Message { get; set; }
    }
    public class UnknownException : Exception
    {
        public new string Message { get; set; }
    }
    #endregion

    /// <summary>
    /// Faz requisições para o servidor
    /// </summary>
    public class ServerApi
    {
        //Configs
        public static string URL { get; set; } = "https://bitcougar.com:5001/v1/appapi";
        #region Internal methods
        public static bool HasSendingError { get; set; } = false;

        private async static Task MakeRequestAsync<Request, Response>(
            Request request, 
            Action<ApiResponse<Response>> sucess, 
            Action<ApiResponse<Response>> error, 
            Action<string> noInternet)
        {
            try
            {
                var apiResponse = await ApiRest.Request<Request, ApiResponse<Response>>(URL, request);
                switch (apiResponse.status)
                {
                    case ApiResponseStatus.Success:
                        sucess?.Invoke(apiResponse);
                        break;
                    case ApiResponseStatus.Error:
                    case ApiResponseStatus.AcessDenied:
                        error?.Invoke(apiResponse);
                        break;
                    case ApiResponseStatus.TokenInvalid:
                        //implementar a tela de sessão expirada


                        break;
                }
            }
            catch (UnknownException e)
            {
                //enviar erro para o servidor
                await SendError(e.Message);
                error?.Invoke(
                    new ApiResponse<Response>
                    {
                        status = ApiResponseStatus.Error, message = DefaultErrorMessage
                    });
            }
            catch(NoInternetException e)
            {
                noInternet?.Invoke(e.Message);
            }
        }
        #endregion

        #region Send error
        public static string DefaultErrorMessage { get; set; } = "Um erro inesperado foi encontrado, " +
                        "estamos enviando todas as informações para nossos servidores " +
                        "para resolver o mais rápido possivel, desculpe o incomodo.";
        public static async Task SendError(string message)
        {
            //evitar loop infinito
            if (!HasSendingError)
            {
                HasSendingError = true;
                var request = new ApiRequest(Endpoint.Create, EndpointType.Error, new List<object> { message });
                await MakeRequestAsync<ApiRequest, object>(request, null, null, null);

                HasSendingError = false;
            }
        }
        public static async Task SendError(Exception e)
        {
            //evitar loop infinito
            if (!HasSendingError)
            {
                HasSendingError = true;
                var request = new ApiRequest(Endpoint.Create, EndpointType.Error, new List<object> { e.Message + "|" + e.StackTrace });
                await MakeRequestAsync<ApiRequest, object>(request, null, null, null);

                HasSendingError = false;
            }
        }
        #endregion

        //Endpoints

        #region Create User VALIDADO
        public static async Task CreateUserAsync(
            User user,
            Action<ApiResponse<object>> success,
            Action<ApiResponse<object>> error,
            Action<string> noInternet)
        {
            var request = new ApiRequest(Endpoint.Create, EndpointType.User, new List<object> { user });
            await MakeRequestAsync(request, success, error, noInternet);
        }
        #endregion

        #region load user  VALIDADO
        public static async Task LoadUserAsync(
            User user,
            Action<ApiResponse<User>> sucess, 
            Action<ApiResponse<User>> error, 
            Action<string> noInternet)
        {
            var data = new
            {
                email = user.Email,
                loginType = LoginType.NycoinLogin,
                password = user.Password
            };
            var request = new ApiRequest(Endpoint.Load, EndpointType.User, new List<object> { data });
            await MakeRequestAsync(request, sucess, error, noInternet);
        }
        #endregion

        #region Load Pair
        public static async Task LoadPairAsync(
            Coin coin1,
            Coin coin2,
            Action<ApiResponse<Pair>> success,
            Action<ApiResponse<Pair>> error,
            Action<string> noInternet)
        {
            var request = new ApiRequest(Endpoint.Load, EndpointType.Pair, new List<object> { coin1, coin2 });
            await MakeRequestAsync(request, success, error, noInternet);
        }

        #endregion

        #region Load AllTradeOrders

        public static async Task LoadAllTradeOrdersAsync(
            Pair pair,
            int limit,
            Action<ApiResponse<List<TradeOrder>>> success,
            Action<ApiResponse<List<TradeOrder>>> error,
            Action<string> noInternet)
        {
            var request = new ApiRequest(Endpoint.Load, EndpointType.AllTradeOrders, new List<object> { pair, limit });
            await MakeRequestAsync(request, success, error, noInternet);
        }

        #endregion

        #region LoadLastPrice
        public static async Task LoadLastPriceAsync(
            Pair pair,
            Action<ApiResponse<double>> success,
            Action<ApiResponse<double>> error,
            Action<string> noInternet)
        {
            var request = new ApiRequest(Endpoint.Load, EndpointType.LastPrice, new List<object> { pair });
            await MakeRequestAsync(request, success, error, noInternet);
        }

        #endregion

        #region LoadPrice
        public static async Task LoadPriceAsync(
            Pair pair,
            Action<ApiResponse<double>> success,
            Action<ApiResponse<double>> error,
            Action<string> noInternet)
        {
            var request = new ApiRequest(Endpoint.Load, EndpointType.Price, new List<object> { pair });
            await MakeRequestAsync(request, success, error, noInternet);
        }

        #endregion

        #region LoadVolume
        public static async Task LoadVolumeAsync(
            Pair pair,
            Action<ApiResponse<double>> success,
            Action<ApiResponse<double>> error,
            Action<string> noInternet)
        {
            var request = new ApiRequest(Endpoint.Load, EndpointType.Volume, new List<object> { pair });
            await MakeRequestAsync(request, success, error, noInternet);
        }

        #endregion

        #region ListItems Banks
        public static async Task ListItemsBankAsync(
            Action<ApiResponse<List<Bank>>> success,
            Action<ApiResponse<List<Bank>>> error,
            Action<string> noInternet)
        {
            var request = new ApiRequest(Endpoint.ListItems, EndpointType.Bank);
            await MakeRequestAsync(request, success, error, noInternet);
        }

        #endregion

        #region ListItems Pair
        public static async Task ListItemsPairAsync(
            Action<ApiResponse<List<Pair>>> success,
            Action<ApiResponse<List<Pair>>> error,
            Action<string> noInternet)
        {
            var request = new ApiRequest(Endpoint.ListItems, EndpointType.Pair);
            await MakeRequestAsync(request, success, error, noInternet);
        }

        #endregion

        #region Create Bank
        public static async Task CreateBankAsync(
            Bank bank,
            Action<ApiResponse<object>> success,
            Action<ApiResponse<object>> error,
            Action<string> noInternet)
        {
            var request = new ApiRequest(Endpoint.Create, EndpointType.Bank, new List<object> { bank });
            await MakeRequestAsync(request, success, error, noInternet);
        }

        #endregion
        
        #region CreateDepositOrder
        public static async Task CreateDepositOrderAsync(
            Deposit deposit,
            Action<ApiResponse<string>> success,
            Action<ApiResponse<string>> error,
            Action<string> noInternet)
        {
            var request = new ApiRequest(Endpoint.Create, EndpointType.DepositOrder, new List<object> { deposit });
            await MakeRequestAsync(request, success, error, noInternet);
        }
        #endregion

        #region CreateWithdrawOrder

        public static async Task CreateWithdrawOrderAsync(
            Withdraw wthdraw,
            Action<ApiResponse<string>> success,
            Action<ApiResponse<string>> error,
            Action<string> noInternet)
        {
            var request = new ApiRequest(Endpoint.Create, EndpointType.WithdrawOrder, new List<object> { wthdraw });
            await MakeRequestAsync(request, success, error, noInternet);
        }

        #endregion

        #region EditBank

        public static async Task EditBankAsync(
            Bank bank,
            Action<ApiResponse<object>> success,
            Action<ApiResponse<object>> error,
            Action<string> noInternet)
        {
            var request = new ApiRequest(Endpoint.Edit, EndpointType.Bank, new List<object> { bank });
            await MakeRequestAsync(request, success, error, noInternet);
        }
        #endregion

        #region listItems coins
        /// <summary>
        /// Carregar todas as moedas da exchange
        /// </summary>
        /// <param name="success"> Codigo que será executado caso dê sucesso</param>
        /// <param name="error">Codigo que será executado caso dê erro<</param>
        /// <param name="noInternet">Codigo que será executado caso fique sem internet<</param>
        /// <returns>void</returns>
        public static async Task ListItemsCoinAsync(
            Action<ApiResponse<List<Coin>>> success,
            Action<ApiResponse<List<Coin>>> error,
            Action<string> noInternet)
        {
            var request = new ApiRequest(Endpoint.ListItems, EndpointType.Coin, new List<object> { });
            await MakeRequestAsync(request, success, error, noInternet);
        }
        #endregion

        #region Create MyTradeOrder Limited

        public static async Task CreateMyTradeOrderLimitedAsync(TradeOrder tradeOrder,
            Action<ApiResponse<TradeOrder>> success,
            Action<ApiResponse<TradeOrder>> error,
            Action<string> noInternet)
        {
            var request = new ApiRequest(Endpoint.Create, EndpointType.MyTradeOrder, new List<object> { tradeOrder });
            await MakeRequestAsync(request, success, error, noInternet);
        }

        #endregion

        #region Create MyTradeOrder Market
        public static async Task CreateMyTradeOrderMarketAsync(TradeOrder tradeOrder,
            Action<ApiResponse<TradeOrder>> success,
            Action<ApiResponse<TradeOrder>> error,
            Action<string> noInternet)
        {
            var request = new ApiRequest(Endpoint.Create, EndpointType.MyTradeOrder, new List<object> { tradeOrder });
            await MakeRequestAsync(request, success, error, noInternet);
        }

        #endregion
    }
}
