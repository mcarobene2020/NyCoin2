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


    public enum EnumTipoCorrecao
    {
        Pre=1,
        Moeda=2,
        Cdi=3

    }

    public class Indexador
{
 
 public Indexador()
 {
 }
 
 ~Indexador()
  {
  }
 
 
 
  private string mdescricao;
  private EnumTipoCorrecao m_tipocorrecao;
  private Moeda m_moeda;
 
 
  public int IdIndexador
  {
   get ;
   set;
   }
 
 
 public string Descricao
 {
  get { return mdescricao; }
  set {mdescricao = value; }
 }
 
 
 public EnumTipoCorrecao m_TipoCorrecao
 {
  get { return m_tipocorrecao; }
  set {m_tipocorrecao = value; }
 }
 
 
 public Moeda m_Moeda
 {
  get { return m_moeda; }
  set {m_moeda = value; }
 }
 
 
 
 
}
}

