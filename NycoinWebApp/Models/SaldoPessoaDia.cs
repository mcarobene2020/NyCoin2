
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

public class SaldoPessoaDia
{
 
 public SaldoPessoaDia()
 {
 }
 
 ~SaldoPessoaDia()
  {
  }
 
 
 
  private SaldoPessoa m_saldopessoa;
  private System.DateTime sdddata;
  private decimal sddsaldobruto;
  private decimal sddsaldoirrf;
  private decimal sddsaldoiof;
  private decimal sddsaldoliquido;
 
 
  [Key]
  public int IdSaldoPessoaDia
  {
   get ;
   set;
   }
 
 
 public SaldoPessoa m_SaldoPessoa
 {
  get { return m_saldopessoa; }
  set {m_saldopessoa = value; }
 }
 
 
 public System.DateTime SddData
 {
  get { return sdddata; }
  set {sdddata = value; }
 }
 
 
 public decimal SddSaldoBruto
 {
  get { return sddsaldobruto; }
  set {sddsaldobruto = value; }
 }
 
 
 public decimal SddSaldoIrrf
 {
  get { return sddsaldoirrf; }
  set {sddsaldoirrf = value; }
 }
 
 
 public decimal SddSaldoIof
 {
  get { return sddsaldoiof; }
  set {sddsaldoiof = value; }
 }
 
 
 public decimal SddSaldoLiquido
 {
  get { return sddsaldoliquido; }
  set {sddsaldoliquido = value; }
 }
 
 
 
 
}
}

