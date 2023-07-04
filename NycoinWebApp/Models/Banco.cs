
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
     
public class Banco
{
 
 public Banco()
 {
 }
 
 ~Banco()
  {
  }
 
 
 
  private string bconumero;
  private string bconome;
 
 
  [Key]
  public int IdBanco
  {
   get ;
   set;
   }
 
  
 public string BcoNumero
 {
  get { return bconumero; }
  set {bconumero = value; }
 }
 
  
 public string BcoNome
 {
  get { return bconome; }
  set {bconome = value; }
 }
 
 
 
 
}
}

