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
     
public class BoletoCaixa
{
 
 public BoletoCaixa()
 {
 }
 
 ~BoletoCaixa()
  {
  }
 
 
 
  private System.DateTime boldata;
  private System.DateTime boldatahora;
  private Pessoa  m_pessoaparte;
  private Pessoa  m_pessoacorretora;
  private Indexador m_indexador;
  private decimal bolpreco;
  private decimal bolvalor;
  private decimal bolquantidade;
  private Banco m_banco;
  private EnumTipoMovimento m_tipomovimento;
  private short bolexecutado;
 
 
  [Key]
  public int IdBoletoCaixa
  {
   get ;
   set;
   }
 
  
 public System.DateTime BolData
 {
  get { return boldata; }
  set {boldata = value; }
 }
 
  
 public System.DateTime BolDataHora
 {
  get { return boldatahora; }
  set {boldatahora = value; }
 }
 
  
 public Pessoa m_PessoaParte
 {
  get { return m_pessoaparte; }
  set {m_pessoaparte = value; }
 }
 
 
  
 public Pessoa m_PessoaCorretora
 {
  get { return m_pessoacorretora; }
  set {m_pessoacorretora = value; }
 }
 
 
 
 public Indexador m_Indexador
 {
  get { return m_indexador; }
  set {m_indexador = value; }
 }
 
  
 public decimal BolPreco
 {
  get { return bolpreco; }
  set {bolpreco = value; }
 }
 
  
 public decimal BolValor
 {
  get { return bolvalor; }
  set {bolvalor = value; }
 }
 
  
 public decimal BolQuantidade
 {
  get { return bolquantidade; }
  set {bolquantidade = value; }
 }
  
 public Banco m_Banco
 {
  get { return m_banco; }
  set {m_banco = value; }
 }
 
  
 public EnumTipoMovimento m_TipoMovimento
 {
  get { return m_tipomovimento; }
  set {m_tipomovimento = value; }
 }
 
  
 public short BolExecutado
 {
  get { return bolexecutado; }
  set {bolexecutado = value; }
 }
 
 
 
 
}
}

