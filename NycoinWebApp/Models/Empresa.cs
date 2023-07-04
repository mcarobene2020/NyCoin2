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

public class Empresa
{
 
 public Empresa()
 {
 }
 
 ~Empresa()
  {
  }
 
 
 
  private string empnome;
  private string empapelido;
  private string empcontato1;
  private string empcontato2;
  private string empcnpj;
  private string empie;
  private string empim;
  private string empcnae;
  private string empcrt;
  private short empmatriz;
 
 
  [Key]
  public int IdEmpresa
  {
   get ;
   set;
   }
 
 
 public string EmpNome
 {
  get { return empnome; }
  set {empnome = value; }
 }
 
 
 public string EmpApelido
 {
  get { return empapelido; }
  set {empapelido = value; }
 }
 
 
 public string EmpContato1
 {
  get { return empcontato1; }
  set {empcontato1 = value; }
 }
 
  
 public string EmpContato2
 {
  get { return empcontato2; }
  set {empcontato2 = value; }
 }
 
 
 public string EmpCNPJ
 {
  get { return empcnpj; }
  set {empcnpj = value; }
 }
 
  
 public string EmpIE
 {
  get { return empie; }
  set {empie = value; }
 }
 
  
 public string EmpIM
 {
  get { return empim; }
  set {empim = value; }
 }
 
  
 public string EmpCNAE
 {
  get { return empcnae; }
  set {empcnae = value; }
 }
 
 
 
 public string EmpCRT
 {
  get { return empcrt; }
  set {empcrt = value; }
 }
 
 
 
 public short EmpMatriz
 {
  get { return empmatriz; }
  set {empmatriz = value; }
 }
 
 
  
 
 
 
 
}
}

