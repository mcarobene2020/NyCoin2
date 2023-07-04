
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

public class TipoPessoa
{
 
 public TipoPessoa()
 { 
 } 
 
 ~TipoPessoa()
  { 
  } 
 
 
 
  private string tipnome;
 
 
  [Key]
  public int IdTipoPessoa
  {
   get ;
   set;
   }
 
 
 public string TipNome
 {
  get { return tipnome; }
  set {tipnome = value; }
 }
 
 
 
 
}
}