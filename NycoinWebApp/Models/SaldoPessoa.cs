
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

public class SaldoPessoa
{
 
 public SaldoPessoa()
 {
 }
 
 ~SaldoPessoa()
  {
  }
 
 
 
  private Indexador m_indexador;
  private Pessoa m_pessoa;
  private Pessoa m_pessoacorretora;
  private System.DateTime saldatainicio;
  private decimal salsaldobrutoabertura;
  private decimal salsaldobruto;
  private decimal salsaldoirrf;
  private decimal salsaldoiof;
  private decimal salsaldoliquido;
 
 
  [Key]
  public int IdSaldoPessoa
  {
   get ;
   set;
   }
 
 
 public Indexador m_Indexador
 {
  get { return m_indexador; }
  set {m_indexador = value; }
 }
 
 
 public Pessoa m_Pessoa
 {
  get { return m_pessoa; }
  set {m_pessoa = value; }
 }
 
 
 public Pessoa  m_PessoaCorretora
 {
  get { return m_pessoacorretora; }
  set {m_pessoacorretora = value; }
 }
 
 
 public System.DateTime SalDataInicio
 {
  get { return saldatainicio; }
  set {saldatainicio = value; }
 }
 
 
 public decimal SalSaldoBrutoAbertura
 {
  get { return salsaldobrutoabertura; }
  set {salsaldobrutoabertura = value; }
 }
 
 
 public decimal SalSaldoBruto
 {
  get { return salsaldobruto; }
  set {salsaldobruto = value; }
 }
 
 
 public decimal SalSaldoIrrf
 {
  get { return salsaldoirrf; }
  set {salsaldoirrf = value; }
 }
 
 
 public decimal SalSaldoIof
 {
  get { return salsaldoiof; }
  set {salsaldoiof = value; }
 }
 
 
 public decimal SalSaldoLiquido
 {
  get { return salsaldoliquido; }
  set {salsaldoliquido = value; }
 }
 
 
 
 
}
}

