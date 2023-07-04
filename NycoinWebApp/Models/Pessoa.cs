
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

    public enum EnumFisicaJuridica
    {
        Fisica=1,
        Juridica=2
    }


    public class Pessoa
{
 
 public Pessoa()
 {
 }
 
 ~Pessoa()
  {
  }
 
 
 
  private string pesnome;
  private string pesapelido;
  private EnumFisicaJuridica m_fisjur;
  private TipoPessoa m_tipopessoa;
  private string pescpfcnpj;
  private string pesrfinscr;
 
 
  [Key]
  public int IdPessoa
  {
   get ;
   set;
   }
 
  
 public string PesNome
 {
  get { return pesnome; }
  set {pesnome = value; }
 }
 
  
 public string PesApelido
 {
  get { return pesapelido; }
  set {pesapelido = value; }
 }
 
  
 public EnumFisicaJuridica m_FisJur
 {
  get { return m_fisjur; }
  set {m_fisjur = value; }
 }
  
 public TipoPessoa m_TipoPessoa
 {
  get { return m_tipopessoa; }
  set {m_tipopessoa = value; }
 }
 
  
 public string PesCPFCNPJ
 {
  get { return pescpfcnpj; }
  set {pescpfcnpj = value; }
 }
 
  
 public string PesRFInscr
 {
  get { return pesrfinscr; }
  set {pesrfinscr = value; }
 }
 
 
 
 
}
}

