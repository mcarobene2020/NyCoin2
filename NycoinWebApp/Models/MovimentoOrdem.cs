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
     
    public class MovimentoOrdem:Movimento
    {
 
        public MovimentoOrdem()
        {
        }
 
        ~MovimentoOrdem()
        {
        }

        public MovimentoOrdem(Pessoa _pessoaparte, System.DateTime _datahora, decimal _qtde, decimal _preco)
        {
            m_Pessoa  = _pessoaparte;
            MovDataHora = _datahora;
            MovQuantidade = _qtde;
            MovPu= _preco;
     
        }

        private Ordem m_ordem;
 
  
        public int IdMovimentoOrdem
        {
        get ;
        set;
        }
 
   
         public Ordem m_Ordem
         {
          get { return m_ordem; }
          set {m_ordem = value; }
         }
 
 
    }
}

