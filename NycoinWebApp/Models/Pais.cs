
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
     
public class Pais
{
 
 public Pais()
 {
 }
 
 ~Pais()
  {
  }
 
 
 
  private string painome;
  private string painacionalidade;
 
 
  [Key]
  public int IdPais
  {
   get ;
   set;
   }
 
  
 public string PaiNome
 {
  get { return painome; }
  set {painome = value; }
 }
 
  
 public string PaiNacionalidade
 {
  get { return painacionalidade; }
  set {painacionalidade = value; }
 }
 
 
 
 
}
}

