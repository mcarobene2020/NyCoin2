using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NycoinWebApp.Models
{
    public class FaixaInvestimento
    {
        public FaixaInvestimento()
        {
        }
        public FaixaInvestimento(int _idfaixa, string _descricao)
        {
            IdFaixaInvestimento = _idfaixa;
            FaixaNome = _descricao;
        }
        ~FaixaInvestimento()
        {
        }
        public int IdFaixaInvestimento { get; set; }
        public string FaixaNome { get; set; }


    }
}
