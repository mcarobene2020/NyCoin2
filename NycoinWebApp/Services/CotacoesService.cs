using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NycoinWebApp.Models;

namespace NycoinServicesWeb
{
    public class CotacoesService
    {
        public CotacoesService()
        {
        }

        public List<CotacaoMoeda> GetCotacoesMoedas()
        {
            List<CotacaoMoeda> list = new List<CotacaoMoeda>();

            list.Add(new CotacaoMoeda(DateTime.Today, new Moeda("BTC", 1, "Bitcoin"), 419400.00M, 9.17M));
            list.Add(new CotacaoMoeda(DateTime.Today, new Moeda("ETH", 2, "Ethereum"), 1189.00M, 6.25M));
            list.Add(new CotacaoMoeda(DateTime.Today, new Moeda("XRP", 3, "XRP"), 1.858181M, 7.71M));
            list.Add(new CotacaoMoeda(DateTime.Today, new Moeda("BCH", 4, "Bitcoin Cash"), 1856.61M, 11.17M));
            list.Add(new CotacaoMoeda(DateTime.Today, new Moeda("LTC", 5, "Litecoin"), 543.47M, 0.99M));
            list.Add(new CotacaoMoeda(DateTime.Today, new Moeda("DASH", 6, "Dash"), 665.59M, 3.83M));
            list.Add(new CotacaoMoeda(DateTime.Today, new Moeda("ZEC", 7, "Zcash"), 442.53M, 1.49M));

            return list;

        }

    }
}
