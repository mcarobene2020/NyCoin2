
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

    public enum EnumTipoOrdem
    {
        Mercado = 1,
        Book = 2
    }
    public enum EnumTipoMovimentoOrdem
    {
        Compra = 1,
        Venda = 2
    }
    public enum TipoIntervaloCandle
    {
        CincoMinutos,
        QuinzeMinutos,
        TrintaMinutos,
        UmaHora,
        UmDia
    }


    public class Ordem
    {
 
        public Ordem()
        {
        }
 
        ~Ordem()
        {
        }
        
        public Ordem(int _idpessoa , System.DateTime _datahora, decimal _qtde, decimal _preco , int _idmoeda, EnumTipoMovimentoOrdem _tipoMov)
        {
            m_PessoaParte = new Pessoa { IdPessoa = _idpessoa };
            
            OrdDataHora = _datahora;
            OrdQuantidade = _qtde;
            OrdPreco = _preco;
            OrdExecutado = 0;
            m_TipoOrdem = EnumTipoOrdem.Book;
            m_MoedaOrdem = new Moeda { IdMoeda = _idmoeda };
            m_TipoMovimento = _tipoMov;
             
        }
        public Ordem(int _idpessoa, System.DateTime _datahora, decimal _qtde, decimal _preco, int _idmoeda, EnumTipoMovimentoOrdem _tipoMov, EnumTipoOrdem _tipoOrdem)
        {
            m_PessoaParte = new Pessoa { IdPessoa = _idpessoa };
            m_MoedaOrdem = new Moeda { IdMoeda = _idmoeda };
            OrdDataHora = _datahora;
            OrdQuantidade = _qtde;
            OrdPreco = _preco;
            OrdExecutado = 0;
            m_TipoMovimento = _tipoMov;
            m_TipoOrdem = _tipoOrdem;
        }
        private System.DateTime orddata;
        private System.DateTime orddatahora;
        private Pessoa  m_pessoaparte;
        private Pessoa  m_pessoacorretora;
        private Indexador m_indexador;
        private decimal ordpreco;
        private decimal ordquantidade;
        private EnumTipoMovimentoOrdem m_tipomovimento;
        private EnumTipoOrdem m_tipoordem;
        private Moeda m_moedaordem;
        private short ordexecutado;
 
 
        [Key]
        public int IdOrdem
        {   get ;   set;   }
 
 
        public System.DateTime OrdData
        {
            get { return orddata; }
            set {orddata = value; }
        }
 
        public System.DateTime OrdDataHora
        {
            get { return orddatahora; }
            set {orddatahora = value; }
        }
   
        public Pessoa m_PessoaParte
        {
            get { return m_pessoaparte; }
            set {m_pessoaparte = value; }
        }
 
  
        public Pessoa  m_PessoaCorretora
        {
            get { return m_pessoacorretora; }
            set {m_pessoacorretora = value; }
        }
 
  
        public Indexador m_Indexador
        {
            get { return m_indexador; }
            set {m_indexador = value; }
        }
 
  
        public decimal OrdPreco
        {
            get { return ordpreco; }
            set {ordpreco = value; }
        }
 
  
        public decimal OrdQuantidade
        {
            get { return ordquantidade; }
            set {ordquantidade = value; }
        }
   
        public EnumTipoMovimentoOrdem m_TipoMovimento
        {
            get { return m_tipomovimento; }
            set {m_tipomovimento = value; }
        }
 
 
        public EnumTipoOrdem m_TipoOrdem
        {
            get { return m_tipoordem; }
            set {m_tipoordem = value; }
        }
 
  
        public Moeda m_MoedaOrdem
        {
            get { return m_moedaordem; }
            set {m_moedaordem = value; }
        }
 
  
        public short OrdExecutado
        {
            get { return ordexecutado; }
            set {ordexecutado = value; }
        }
 
 
 
    }

    public class Detail
    {
        public decimal VlrAbertura { get; set; }
        public decimal VlrFechamento { get; set; }
        public decimal VlrMaximo { get; set; }
        public decimal VlrMinimo { get; set; }
        public System.DateTime HorarioInicio { get; set; }

         
    }

    public class OrdensDetalhe
    {
        public List<Ordem> LstOrdem { get; set; }
        public List<DataPointCandle> DetailCandle { get; set; }
        public OrdensDetalhe()
        {
            LstOrdem = new List<Ordem>();
            DetailCandle = new List<DataPointCandle>();
            

        }


    }
}

