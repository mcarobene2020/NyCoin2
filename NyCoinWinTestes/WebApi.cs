using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using nycoinserver.Models;
using Environment = nycoinserver.Models.Environment;

namespace testeWebApi
{
    public static class WebApi
    {
        public static async Task<Response<ReturnType>> MakeRequest<ReturnType>(Request request)
        {
            try
            {
                HttpClient client = new HttpClient
                {
                    BaseAddress = new Uri("https://bitcougar.com:5001/" + request.Url)
                };
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PostAsJsonAsync(client.BaseAddress, request);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsAsync<Response<ReturnType>>();
            }
            catch (Exception oe)
            {
                return new Response<ReturnType>
                {
                    Status = ReturnStatus.Error,
                    Message = oe.Message
                };
            }
        }

        public static async Task<User> Logar(string email, string senha)
        {
            try
            {
                var usuario = new User
                {
                    Email = email,
                    LoginType = LoginType.NycoinLogin,
                    Password = senha
                };

                var requisicao = new Request
                {
                    Url = "v1/load/user",
                    Data = new List<object> { usuario },
                    Environment = Environment.Development
                };

                var resposta = await WebApi.MakeRequest<User>(requisicao);

                if (resposta.Status == ReturnStatus.Success)
                {
                    //usuario logado
                    //retornar usuario
                    return resposta.Data;
                }
                else
                {
                    //caso deu algum problema você pode mostrar
                    //o problema pro usuario.
                    var problema = resposta.Message;

                    //retornando nulo pra saber que não deu certo
                    return null;
                }
            }
            catch (Exception oe)
            {
                throw oe;
            }
        }

        public static async void ListarMoedas()
        {
            var requisicao = new Request
            {
                Url = "v1/listitems/coin",
                Environment = Environment.Development
            };

            var resposta = await MakeRequest<List<Coin>>(requisicao);

            if (resposta.Status == ReturnStatus.Success)
            {
                //lista de moedas
                var listaDeMoedas = resposta.Data;
            }
            else
            {
                //algum problema aconteceu
                var problema = resposta.Message;
            }
        }

        public static async void CarregarOrdensDoPar()
        {
            try
            {
                //se você não souber o idPair é só chamar o metodo CarregarPares e pegar o primeiro item da lista
                //assim:
                //var par = await CarregarPares()[0];
                var par = new Pair
                {
                    IdPair = 2  //o 2 é o par bitcoin/real
                };

                var requisicao = new Request
                {
                    Url = "v1/load/alltradeorders",
                    Data = new List<object> { par },
                    Environment = Environment.Development
                };

                var resposta = await MakeRequest<List<TradeOrder>>(requisicao);

                if (resposta.Status == ReturnStatus.Success)
                {
                    //lista de ordens, tanto de compra, quanto venda e executadas
                    var listaGeral = resposta.Data;

                    var listaCompra = new List<TradeOrder>();
                    var listaVenda = new List<TradeOrder>();
                    var listaExecutadas = new List<TradeOrder>();

                    foreach (var ordem in listaGeral)
                    {
                        switch (ordem.Type)
                        {
                            case TradeType.BuyOrder: //caso seja de compra
                                listaCompra.Add(ordem);
                                break;
                            case TradeType.SellOrder: //caso seja de venda
                                listaVenda.Add(ordem);
                                break;
                            case TradeType.ExecOrder: //caso seja executada
                                listaExecutadas.Add(ordem);
                                break;
                        }
                    }
                }
                else
                {
                    //algum problema aconteceu
                    var problema = resposta.Message;
                }
            }
            catch (Exception oe)
            {
                throw oe;
            }

        }

        public static async Task<List<Pair>> CarregarPares()
        {
            try
            {
                var requisicao = new Request
                {
                    Url = "v1/listitems/pairs",
                    Data = null, //tanto faz ser nulo ou new List<object>()
                };

                var resposta = await MakeRequest<List<Pair>>(requisicao);

                if (resposta.Status == ReturnStatus.Success)
                {
                    //lista de pares
                    var listaDePares = resposta.Data;

                    return listaDePares;
                }
                else
                {
                    //algum problema aconteceu
                    var problema = resposta.Message;

                    return null;
                }
            }
            catch (Exception oe)
            {
                throw oe;
            }

        }

        public static async void CarregarSaldo()
        {
            try
            {
                var requisicao = new Request
                {
                    Url = "v1/load/balance",
                    Data = null, //tanto faz ser nulo ou new List<object>()
                    Environment = Environment.Development, //opcional, não é necessario colocar, o valor padrão é development maaas deveria ser production
                    Token = "a613b299-4d71-4bab-af9c-86aa9cdce969"
                };

                var resposta = await MakeRequest<List<Balance>>(requisicao);

                if (resposta.Status == ReturnStatus.Success)
                {
                    //saldos do usuario
                    var saldoEmNano = resposta.Data[0].UserBalance.Value;
                    var saldoEmBitcoin = resposta.Data[1].UserBalance.Value;
                    var saldoEmReal = resposta.Data[2].UserBalance.Value;
                }
                else
                {
                    //aconteceu algum problema
                    var problema = resposta.Message;
                }
            }
            catch (Exception oe)
            {
                throw oe;
            }
        }
        
        public static async void CriarOrdemDeCompraLimitada(Pair par, double cotacao, double valor)
        {
            var ordem = new TradeOrder
            {
                Type = TradeType.BuyOrder,
                IdPair = par.IdPair,
                Price = cotacao,
                Amount = valor,
                ExecutedWay = TradeExecutedWay.LimitedOrder
            };

            var requisicao = new Request
            {
                Url = "v1/create/tradeorder",
                Data = new List<object> { ordem },
                Token = "a613b299-4d71-4bab-af9c-86aa9cdce969"
            };

            var resposta = await MakeRequest<object>(requisicao);

            if (resposta.Status == ReturnStatus.Success)
            {
                //tudo certo, ordem criada
            }
            else
            {
                //aconteceu algum problema
                var problema = resposta.Message;
            }
        }


            /*

        static void ShowProduct(Product product)
        {
            Console.WriteLine($"Name: {product.Name}\tPrice: " +
                $"{product.Price}\tCategory: {product.Category}");
        }

        static async Task<Uri> CreateProductAsync(Product product)
        {
            HttpClient client = new System.Net.Http.HttpClient();
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/products", product);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        static async Task<Product> GetProductAsync(string path)
        {
            Product product = null;
            HttpClient client = new System.Net.Http.HttpClient();
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Product>();
            }
            return product;
        }

        static async Task<Product> UpdateProductAsync(Product product)
        {

            HttpClient client = new System.Net.Http.HttpClient();

            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"api/products/{product.Id}", product);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            product = await response.Content.ReadAsAsync<Product>();
            return product;
        }

        static async Task<HttpStatusCode> DeleteProductAsync(string id)
        {
            HttpClient client = new System.Net.Http.HttpClient();
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/products/{id}");
            return response.StatusCode;
        }

        //static void Main()
        //{
        //    RunAsync().GetAwaiter().GetResult();
        //}

        static async Task RunAsync()
        {
            HttpClient client = new System.Net.Http.HttpClient();
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://bitcougar.com:5001/v1/appapi/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                // Create a new product
                Product product = new Product
                {
                    Name = "Gizmo",
                    Price = 100,
                    Category = "Widgets"
                };

                var url = await CreateProductAsync(product);
                Console.WriteLine($"Created at {url}");

                // Get the product
                product = await GetProductAsync(url.PathAndQuery);
                ShowProduct(product);

                // Update the product
                Console.WriteLine("Updating price...");
                product.Price = 80;
                await UpdateProductAsync(product);

                // Get the updated product
                product = await GetProductAsync(url.PathAndQuery);
                ShowProduct(product);

                // Delete the product
                var statusCode = await DeleteProductAsync(product.Id);
                Console.WriteLine($"Deleted (HTTP Status = {(int)statusCode})");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }*/
    }

}
