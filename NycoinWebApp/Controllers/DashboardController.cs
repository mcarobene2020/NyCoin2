using NycoinServicesWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using NycoinWebApp.Models;

namespace NycoinWebApp.Controllers
{
    public class DashboardController : Controller
    {
        private static OrdemService ordemService;
        private static CotacoesService cotacoesService;
        private static ClienteService clienteService;

        private static OrdemService GetOrdemService()
        {
            if (ordemService == null)
                ordemService = new OrdemService();
            return ordemService;
        }
        private static ClienteService GetClienteService()
        {
            if (clienteService == null)
                clienteService = new ClienteService();
            return clienteService;
        }
        private static CotacoesService GetCotacoesService()
        {
            if (cotacoesService == null)
                cotacoesService = new CotacoesService();
            return cotacoesService;
        }
        public ActionResult PlataformaBasica()
        {
            JsonSerializerSettings jsonSetting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };

           // OrdemService ordemService = new OrdemService();
            OrdensDetalhe ordensDetalhe = GetOrdemService().GetOrdensDetalhe();

            TempData["OrdensBook"] = JsonConvert.SerializeObject(ordensDetalhe.LstOrdem);
            TempData["CotacoesMoedas"] = JsonConvert.SerializeObject(GetCotacoesService().GetCotacoesMoedas());
            TempData["SaldoPessoa"] = JsonConvert.SerializeObject(GetClienteService().GetSaldoPessoa(0));

            //Below code can be used to include dynamic data in Chart. Check view page and uncomment the line "dataPoints: @Html.Raw(ViewBag.DataPoints)"
            ViewBag.DataPoints = JsonConvert.SerializeObject(GetOrdemService().GetGraphicSplineAreaOrdens(), jsonSetting);

            return View();
        }

        [HttpPost]
        public bool AddOrder(decimal preco, decimal quantidade, string sNomMoeda, int idMoeda, int idTipoMov)
        {
            var pessoa = new Pessoa();
            pessoa.IdPessoa = 1;
            pessoa.PesCPFCNPJ = "56600154098";
            pessoa.m_TipoPessoa = new TipoPessoa() { IdTipoPessoa = 1, TipNome = "" };

            var ordem = new Ordem();
            ordem.m_PessoaParte = pessoa;

            ordem.IdOrdem = 1;
            ordem.OrdDataHora = DateTime.Now;
            ordem.OrdPreco = preco;
            ordem.OrdQuantidade = quantidade;
            ordem.OrdData = DateTime.Now;
            ordem.OrdExecutado = 1;
            ordem.m_MoedaOrdem = new Moeda(sNomMoeda, idMoeda);
            EnumTipoMovimentoOrdem enumTipo =(EnumTipoMovimentoOrdem) idTipoMov;
            ordem.m_TipoMovimento = enumTipo;

            // var response = new OrdemService().AddOrdem(ordem);
            var response = GetOrdemService().AddOrdem(ordem);
            return response;
        }

        [HttpPost]
        public string GetOrdensCompra(int idMoeda)
        {
            return JsonConvert.SerializeObject(GetOrdemService().GetOrdensCompra(idMoeda));
           // return JsonConvert.SerializeObject(new OrdemService().GetOrdensAtivasCliente(1));
        }

        [HttpPost]
        public string GetOrdensVenda(int idMoeda)
        {
            return JsonConvert.SerializeObject(GetOrdemService().GetOrdensVenda(idMoeda));
           // return JsonConvert.SerializeObject(new OrdemService().GetOrdensAtivasCliente(1));
        }

        public string GetCoinsQuotation()
        {
            return JsonConvert.SerializeObject(GetCotacoesService().GetCotacoesMoedas());
        }

        public ActionResult PlataformaAvancada()
        {
            OrdensDetalhe ordensDetalhe = GetOrdemService().GetOrdensDetalhe();
            TempData["OrdensBook"] = JsonConvert.SerializeObject(ordensDetalhe.LstOrdem);
            TempData["CotacoesMoedas"] = JsonConvert.SerializeObject(GetCotacoesService().GetCotacoesMoedas());
            TempData["SaldoPessoa"] = JsonConvert.SerializeObject(GetClienteService().GetSaldoPessoa(0));

            TempData["OrdensAbertas"] = JsonConvert.SerializeObject(GetOrdemService().GetOrdensAtivas(0));
            TempData["OrdensExecutadas"] = JsonConvert.SerializeObject(ordensDetalhe.LstOrdem);
            TempData["OrdensInativas"] = JsonConvert.SerializeObject("");
            ViewBag.DataPoints = JsonConvert.SerializeObject(ordensDetalhe.DetailCandle);

            return View();
        }
    }
}