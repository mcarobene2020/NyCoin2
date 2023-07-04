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

    public class Moeda
    {
 
        public Moeda()
        {
        }

        public Moeda(string _sigla, int _id, string _nome = "")
        {
            this.MoeNome = string.IsNullOrEmpty(_sigla) ? _nome : _sigla; 
            this.MoeSigla = _nome;
            this.IdMoeda = _id;
        }

        ~Moeda()
        {
        }
 
 
 
        private string moenome;
        private string moesigla;
        private string moetipo;
 
        public int IdMoeda
        {
        get ;
        set;
        }
 
  
        public string MoeNome
        {
        get { return moenome; }
        set {moenome = value; }
        }
 
  
        public string MoeSigla
        {
        get { return moesigla; }
        set {moesigla = value; }
        }
 
  
        public string MoeTipo
        {
        get { return moetipo; }
        set {moetipo = value; }
        }
 
 
 
 
    }
}

