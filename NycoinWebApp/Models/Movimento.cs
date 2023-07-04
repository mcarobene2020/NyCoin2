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


    public enum EnumTipoMovimento
    {
        Compra=1,
        Venda=2
    }

    public class Movimento
{
 
 public Movimento()
 {
 }
 
 ~Movimento()
  {
  }
 
 
 
  private Pessoa m_pessoa;
  private Pessoa m_pessoacorretora;
  private System.DateTime movdata;
  private System.DateTime movdatahora;
  private decimal movquantidade;
  private decimal movvalor;
  private decimal movpu;
 
 
  public int IdMovimento
  {
   get ;
   set;
   }
 
 
 public Pessoa m_Pessoa
 {
  get { return m_pessoa; }
  set {m_pessoa = value; }
 }
 
 
 public Pessoa m_PessoaCorretora
 {
  get { return m_pessoacorretora; }
  set {m_pessoacorretora = value; }
 }
 
  
 public System.DateTime MovData
 {
  get { return movdata; }
  set {movdata = value; }
 }
 
  
 public System.DateTime MovDataHora
 {
  get { return movdatahora; }
  set {movdatahora = value; }
 }
 
  
 public decimal MovQuantidade
 {
  get { return movquantidade; }
  set {movquantidade = value; }
 }
 
  
 public decimal MovValor
 {
  get { return movvalor; }
  set {movvalor = value; }
 }
 
  
 public decimal MovPu
 {
  get { return movpu; }
  set {movpu = value; }
 }
 
 
 
 
}
}

