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

     
public class ContaCorrente
{
 
 public ContaCorrente()
 {
 }
 
 ~ContaCorrente()
  {
  }
 
 
 
  private Pessoa m_pessoa;
  private TipoPessoa m_tipopessoa;
  private Banco m_banco;
  private string ccoconta;
  private string ccoagencia;
  private string ccodigito;
  private string ccologradouro;
  private string cconumero;
  private string ccocomplemento;
  private string ccobairro;
  private string ccocidade;
  private string ccoestado;
  private string ccocep;
 
 
  [Key]
  public int IdContaCorrente
  {
   get ;
   set;
   }
 
  
 public Pessoa m_Pessoa
 {
  get { return m_pessoa; }
  set {m_pessoa = value; }
 }
 
  
 public TipoPessoa m_TipoPessoa
 {
  get { return m_tipopessoa; }
  set {m_tipopessoa = value; }
 }
 
  
 public Banco m_Banco
 {
  get { return m_banco; }
  set {m_banco = value; }
 }
  
 public string CCoConta
 {
  get { return ccoconta; }
  set {ccoconta = value; }
 }
 
  
 public string CCoAgencia
 {
  get { return ccoagencia; }
  set {ccoagencia = value; }
 }
 
  
 public string CCoDigito
 {
  get { return ccodigito; }
  set {ccodigito = value; }
 }
 
  
 public string CCoLogradouro
 {
  get { return ccologradouro; }
  set {ccologradouro = value; }
 }
 
  
 public string CCoNumero
 {
  get { return cconumero; }
  set {cconumero = value; }
 }
 
  
 public string CCoComplemento
 {
  get { return ccocomplemento; }
  set {ccocomplemento = value; }
 }
 
  
 public string CCoBairro
 {
  get { return ccobairro; }
  set {ccobairro = value; }
 }
 
  
 public string CCoCidade
 {
  get { return ccocidade; }
  set {ccocidade = value; }
 }
 
  
 public string CCoEstado
 {
  get { return ccoestado; }
  set {ccoestado = value; }
 }
 
  
 public string CCoCep
 {
  get { return ccocep; }
  set {ccocep = value; }
 }
 
 
 
 
}
}

