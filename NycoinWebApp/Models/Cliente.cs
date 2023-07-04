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

    public class Cliente:Pessoa
    {
 
        public Cliente()
        {
        }
 
        ~Cliente()
        {
        }
 
    
        public int IdCliente { get; set; }
        public string CliLogin { get; set; }
        public string CliSenha { get; set; }
        public string CliSexo { get; set; }
        public string CliCelular { get; set; }
        public string CliDataNacto { get; set; }
        //public System.DateTime CliDataNacto { get; set; }
        public string CliCep { get; set; }
        public string CliEndereco { get; set; }
        public string CliBairro { get; set; }
        public string CliCidade { get; set; }
        public string CliEstado { get; set; }
        public string CliNumero { get; set; }
        public string CliComplemento { get; set; }
        public string CliConfirmaTermoAdesao { get; set; }
        public bool CliConfirmaTermoCompra { get; set; }
        public FaixaInvestimento FaixaInvestimento;
    }
}

