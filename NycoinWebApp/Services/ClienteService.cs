using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NycoinWebApp.Models;

namespace NycoinServicesWeb
{
    public class ClienteService
    {
        public ClienteService()
        {

        }
        public SaldoPessoa GetSaldoPessoa(int _idcliente)
        {
            SaldoPessoa saldo = new SaldoPessoa();
            saldo.m_Pessoa = new Pessoa();
            saldo.m_Pessoa.IdPessoa = _idcliente;
            saldo.SalDataInicio = DateTime.Today;
            saldo.SalSaldoBruto = 22400.00M;
            saldo.SalSaldoLiquido = 22650.00M;
            return saldo;
        }
    

        public List<MovimentoCaixa> GetDepositosExecutadoasCliente(int _idcliente)
        {
            List<MovimentoCaixa> lstdeposito = new List<MovimentoCaixa>();
            return lstdeposito;
        }
    }
}
