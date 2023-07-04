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
     
public class MovimentoCaixa:Movimento
{
 
 public MovimentoCaixa()
 {
 }
 
 ~MovimentoCaixa()
  {
  }
 
 
  
  private BoletoCaixa m_boletocaixa;
 
  
  public int IdMovimentoCaixa
  {
   get ;
   set;
   }
 
   
  
 public BoletoCaixa m_BoletoCaixa
 {
  get { return m_boletocaixa; }
  set {m_boletocaixa = value; }
 }
 
 
 
 
}
}

