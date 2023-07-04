using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NycoinWebApp.Models;
using nycoinserver.Models;

namespace NycoinServicesWeb
{
    public class OrdemService
    {
        public static OrdensDetalhe OrdensDetalhes { get; set; }
        private bool mUtilizaWebApi = false;

        public OrdemService(bool utilizaWebApi)
        {
            mUtilizaWebApi = utilizaWebApi;
        }

        public OrdemService()
        {
            if (OrdensDetalhes == null)
                OrdensDetalhes = new OrdensDetalhe();

           
            OrdensDetalhes.LstOrdem = GetOrdens();
            FillObject(DateTime.Now, DateTime.Now);

        }

        ////Substituir
        //pela busca no WebApi. Deve Retornar na ordem crescente de valores
        //////
        private List<Ordem> GetOrdens()
        {
         
            ///
            int _idcliente = 1;
            
            List<Ordem> lstOrdem = new List<Ordem>();
            lstOrdem.Add(new Ordem(_idcliente, DateTime.Now.AddHours(-5.6868), 0.356049309M, 43012.00M, 1, EnumTipoMovimentoOrdem.Venda));
            lstOrdem.Add(new Ordem(_idcliente, DateTime.Now.AddHours(-5), 0.450493409M, 42120.00M, 1, EnumTipoMovimentoOrdem.Venda));
            lstOrdem.Add(new Ordem(_idcliente, DateTime.Now.AddHours(-4.940), 0.300493409M, 43020.00M, 1, EnumTipoMovimentoOrdem.Compra));
            lstOrdem.Add(new Ordem(_idcliente, DateTime.Now.AddHours(-4.4), 0.580493409M, 44023.00M, 1, EnumTipoMovimentoOrdem.Venda));
            lstOrdem.Add(new Ordem(_idcliente, DateTime.Now.AddHours(-4.23), 0.450493409M, 42020.00M, 1, EnumTipoMovimentoOrdem.Compra));
            lstOrdem.Add(new Ordem(_idcliente, DateTime.Now.AddHours(-3.19), 0.27839809M, 45031.00M, 1, EnumTipoMovimentoOrdem.Venda));
            lstOrdem.Add(new Ordem(_idcliente, DateTime.Now.AddHours(-3.12), 0.580493409M, 44020.00M, 1, EnumTipoMovimentoOrdem.Compra));
            lstOrdem.Add(new Ordem(_idcliente, DateTime.Now.AddHours(-3.08), 0.24239809M, 45020.00M, 1, EnumTipoMovimentoOrdem.Compra));
            lstOrdem.Add(new Ordem(_idcliente, DateTime.Now.AddHours(-3.00193), 0.439493409M, 46110.00M, 1, EnumTipoMovimentoOrdem.Venda));
            lstOrdem.Add(new Ordem(_idcliente, DateTime.Now.AddHours(-3.001), 0.009493409M, 46020.00M, 1, EnumTipoMovimentoOrdem.Compra));
            lstOrdem.Add(new Ordem(_idcliente, DateTime.Now.AddHours(-2.9821), 0.004578709M, 47020.00M, 1, EnumTipoMovimentoOrdem.Compra));
            lstOrdem.Add(new Ordem(_idcliente, DateTime.Now.AddHours(-2.5), 0.0112309709M, 43421.20M, 1, EnumTipoMovimentoOrdem.Venda));
            lstOrdem.Add(new Ordem(_idcliente, DateTime.Now.AddHours(-2.3), 0.03234599M, 48015.10M, 1, EnumTipoMovimentoOrdem.Venda));
            lstOrdem.Add(new Ordem(_idcliente, DateTime.Now.AddHours(-2.2536), 0.04204599M, 48020.00M, 1, EnumTipoMovimentoOrdem.Compra));
            lstOrdem.Add(new Ordem(_idcliente, DateTime.Now.AddHours(-1.86315), 0.001129849M, 49480.00M, 1, EnumTipoMovimentoOrdem.Compra));
            lstOrdem.Add(new Ordem(_idcliente, DateTime.Now.AddHours(-1.613742), 0.056729842M, 49489.10M, 1, EnumTipoMovimentoOrdem.Venda));
            return lstOrdem;

        }
        public bool AddOrdem(Ordem _novaordem)
        {
            OrdensDetalhes.LstOrdem.Add(_novaordem);
            return true;

        }

        public OrdensDetalhe GetOrdensDetalhe()
        {
            FillObject(DateTime.Now, DateTime.Now);
            return OrdensDetalhes;
        }

        public OrdensDetalhe GetOrdensDetalhe(DateTime _timeini, DateTime _timefim)
        {
            FillObject(_timeini, _timefim);
            return OrdensDetalhes;
        }

        public void FillObject(DateTime _horaini, DateTime _horafim)
        {
            int i = OrdensDetalhes.LstOrdem.Count;
            if (i == 0)
                return;
            /* Detail detail = new Detail();


             detail.VlrAbertura = OrdensDetalhes.LstOrdem[0].OrdPreco;
             detail.VlrFechamento = OrdensDetalhes.LstOrdem[OrdensDetalhes.LstOrdem.Count - 1].OrdPreco;
             detail.VlrMaximo = OrdensDetalhes.LstOrdem.Max(t => t.OrdPreco);
             detail.VlrMinimo = OrdensDetalhes.LstOrdem.Min(t => t.OrdPreco);
             detail.HorarioInicio = _horaini;*/
            OrdensDetalhes.DetailCandle.Clear();

            OrdensDetalhes.DetailCandle.Add(new DataPointCandle(new DateTime(2019, 07, 02, 08, 00, 00), new double[] { 41810, 41910, 41790, 41890.5 }));
            OrdensDetalhes.DetailCandle.Add(new DataPointCandle(new DateTime(2019, 07, 02, 08, 15, 00), new double[] { 41850, 41999, 41800, 41822.5 }));
            OrdensDetalhes.DetailCandle.Add(new DataPointCandle(new DateTime(2019, 07, 02, 08, 30, 00), new double[] { 41810, 41999, 41700, 41890.5 }));
            OrdensDetalhes.DetailCandle.Add(new DataPointCandle(new DateTime(2019, 07, 02, 08, 45, 00), new double[] { 41810, 41999, 41700, 41890.5 }));
            OrdensDetalhes.DetailCandle.Add(new DataPointCandle(new DateTime(2019, 07, 02, 09, 00, 00), new double[] { 41810, 41999, 41700, 41890.5 }));
            OrdensDetalhes.DetailCandle.Add(new DataPointCandle(new DateTime(2019, 07, 02, 09, 15, 00), new double[] { 41810, 41999, 41700, 41890.5 }));
            OrdensDetalhes.DetailCandle.Add(new DataPointCandle(new DateTime(2019, 07, 02, 09, 30, 00), new double[] { 41810, 41999, 41700, 41890.5 }));
            OrdensDetalhes.DetailCandle.Add(new DataPointCandle(new DateTime(2019, 07, 02, 09, 45, 00), new double[] { 41810, 41999, 41700, 41890.5 }));
            OrdensDetalhes.DetailCandle.Add(new DataPointCandle(new DateTime(2019, 07, 02, 10, 00, 00), new double[] { 41810, 41999, 41700, 41890.5 }));
            OrdensDetalhes.DetailCandle.Add(new DataPointCandle(new DateTime(2019, 07, 02, 10, 15, 00), new double[] { 41810, 41999, 41700, 41890.5 }));
            OrdensDetalhes.DetailCandle.Add(new DataPointCandle(new DateTime(2019, 07, 02, 10, 30, 00), new double[] { 41810, 41999, 41700, 41890.5 }));

             
        }

        public List<Ordem> GetOrdensAtivas(int _idcliente)
        { 

            return OrdensDetalhes.LstOrdem;
        }
        public List<Ordem> GetOrdensExecutadas()
        {

            return OrdensDetalhes.LstOrdem;
        }


        public List<Ordem> GetOrdensAtivasCliente(int _idcliente)
        {
            
            return OrdensDetalhes.LstOrdem.Where(p => (p.m_PessoaParte.IdPessoa == _idcliente)).ToList<Ordem>(); ;
        }
        public List<Ordem> GetOrdensExecutadasCliente(int _idcliente)
        {

            return OrdensDetalhes.LstOrdem.Where(p => (p.m_PessoaParte.IdPessoa == _idcliente)).ToList<Ordem>(); ;
        }
        public List<Ordem> GetOrdensCompra(int _idmoeda)
        {
            List<Ordem> lstret = new List<Ordem>();
            int counter = 0;
            for(int i= OrdensDetalhes.LstOrdem.Count-1; i>0;i-- )
            {
                if(OrdensDetalhes.LstOrdem[i].m_TipoMovimento == EnumTipoMovimentoOrdem.Compra)
                {
                    lstret.Add(OrdensDetalhes.LstOrdem[i]);
                    counter += 1;
                    if (counter == 7)
                        break;
                }
            }
            return lstret;
            //return OrdensDetalhes.LstOrdem.Where(p => (p.m_TipoMovimento == EnumTipoMovimentoOrdem.Compra)).ToList<Ordem>();
        }
        public List<Ordem> GetOrdensVenda(int _idmoeda)
        {
            List<Ordem> lstret = new List<Ordem>();
            int counter = 0;
            for (int i = OrdensDetalhes.LstOrdem.Count - 1; i > 0; i--)
            {
                if (OrdensDetalhes.LstOrdem[i].m_TipoMovimento == EnumTipoMovimentoOrdem.Venda)
                {
                    lstret.Add(OrdensDetalhes.LstOrdem[i]);
                    counter += 1;
                    if (counter == 7)
                        break;
                }
            }
            return lstret;
           // return OrdensDetalhes.LstOrdem.Where(p => (p.m_TipoMovimento == EnumTipoMovimentoOrdem.Venda)).ToList<Ordem>();
        }

       
        /// <summary>
        /// Obtém a Lista de Ordens no formato do gráfico SplineArea, plataforma básica
        /// O DataPointTime é o objeto que é convertido no JavaScript para o gráfico CanvasJS
        /// </summary>
        /// <returns>List<DataPointTime></DataPointTime></returns>
        public   List<DataPointTime> GetGraphicSplineAreaOrdens()
        {
            List<DataPointTime> lst = new List<DataPointTime>();


            foreach(Ordem ordem in OrdensDetalhes.LstOrdem)
            {
                lst.Add(new DataPointTime(ordem.OrdDataHora, Convert.ToDouble(ordem.OrdPreco)));
            }
           return lst;
        }

        /// <summary>
        /// Obtém a Lista de dados das Ordens no formato do gráfico CandleStick, plataforma avançada
        /// O DataPointCandle é o objeto que é convertido no JavaScript para o gráfico CanvasJS
        /// </summary>
        /// <returns>List<DataPointTime></DataPointTime></returns>
        public List<DataPointCandle> GetGraphicCandleStick(TipoIntervaloCandle tipoIntervalo)
        {
            List<DataPointCandle> lst = new List<DataPointCandle>();


            //foreach (Ordem ordem in OrdensDetalhes.LstOrdem)
            //{
            //    lst.Add(new DataPointTime(ordem.OrdDataHora, Convert.ToDouble(ordem.OrdPreco)));
            //}
            return lst;
        }
    }
}