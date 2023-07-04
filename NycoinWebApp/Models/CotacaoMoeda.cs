using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;



namespace NycoinWebApp.Models
{

    public class CotacaoMoeda
    {

        public CotacaoMoeda()
        {
        }

        ~CotacaoMoeda()
        {
        }

        public CotacaoMoeda(DateTime _cotdata, Moeda _moeda, decimal _valor, decimal _variacao)
        {
            CotData = _cotdata;
            m_MoedaCotada = _moeda;
            CotValor = _valor;
            cotvariacaodiaria = _variacao;
        }

        private System.DateTime cotdata;
        private Moeda m_moedacotada;
        private Moeda m_moedareferencia;
        private decimal cotvalor;
        private decimal cotvariacaodiaria;

        [Key]
        public int IdCotacaoMoeda
        {
            get;
            set;
        }


        public System.DateTime CotData
        {
            get { return cotdata; }
            set { cotdata = value; }
        }


        public Moeda m_MoedaCotada
        {
            get { return m_moedacotada; }
            set { m_moedacotada = value; }
        }


        public Moeda m_MoedaREferencia
        {
            get { return m_moedareferencia; }
            set { m_moedareferencia = value; }
        }


        public decimal CotValor
        {
            get { return cotvalor; }
            set { cotvalor = value; }
        }


        public decimal CotVariacaoDiaria
        {
            get { return cotvariacaodiaria; }
            set { cotvariacaodiaria = value; }
        }

    }


}

