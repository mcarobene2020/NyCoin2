using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NycoinWebApp.Models;

namespace NycoinServicesWeb
{
    public class InvestimentoService
    {

        public InvestimentoService() { }

        public List<FaixaInvestimento> GetFaixaInvestimentos()
        {
            List<FaixaInvestimento> list = new List<FaixaInvestimento>();
            list.Add(new FaixaInvestimento(1, "0 - R$ 100 mil"));
            list.Add(new FaixaInvestimento(2, "R$ 100 mil a R$ 300 mil"));
            list.Add(new FaixaInvestimento(3, "Acima de R$ 300 mil"));
            list.Add(new FaixaInvestimento(4, "Ainda não sei"));
            return list;
          
        }
    }
}
