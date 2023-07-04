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
     
public class Corretora:Pessoa
{
 
 public Corretora()
 {
 }
 
 ~Corretora()
  {
  }
 
 
 
  private string cornome;
  private string corapelido;
  private string corcontato1;
  private string corcontato2;
  private string corcnpj;
  private string corie;
  private short cormatriz; 
 
  
  public int IdCorretora
  {
   get ;
   set;
   }
 
  
 public string CorNome
 {
  get { return cornome; }
  set {cornome = value; }
 }
 
  
 public string CorApelido
 {
  get { return corapelido; }
  set {corapelido = value; }
 }
 
  
 public string CorContato1
 {
  get { return corcontato1; }
  set {corcontato1 = value; }
 }
 
  
 public string CorContato2
 {
  get { return corcontato2; }
  set {corcontato2 = value; }
 }
 
  
 public string CorCNPJ
 {
  get { return corcnpj; }
  set {corcnpj = value; }
 }
 
  
 public string Corie
 {
  get { return corie; }
  set {corie = value; }
 }
 
  
 public short CorMatriz
 {
  get { return cormatriz; }
  set {cormatriz = value; }
 }
 
   
 
 
 
}
}

