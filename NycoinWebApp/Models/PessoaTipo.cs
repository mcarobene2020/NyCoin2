
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
     
    public class PessoaTipo
    {
 
         public PessoaTipo()
         {
         }
 
         ~PessoaTipo()
          {
          }
 
 
 
          private Pessoa m_pessoa;
          private TipoPessoa m_tipopessoa;
 
 
          [Key]
          public int IdPessoaTipo
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
 
 
 
 
    }
}

