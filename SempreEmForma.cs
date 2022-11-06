using System;

namespace SempreEmForma
{ 

 public class Pessoa
 {
   private string Nome;
   private int Peso;
   private double Altura;
  
   //Construtor
   Pessoa(string Nome, double Altura,int Peso)
   {
     this.Nome   = Nome;
     this.Altura = Altura;
     this.Peso = Peso;
   } 

   //Métodos GET
   public string getNome(){
      return(Nome);     
   }

    public int getPeso(){
      return(Peso);     
   }
   
   public double getAltura(){
      return(Altura);     
   }

   //Métodos SET
   public void setNome(string Nome){
     this.Nome = Nome;    
   }

   public void setPeso(int Peso){
     this.Peso = Peso;    
   }
   
   public void setAltura(double Altura){
     this.Altura = Altura;    
   }
     
   //Métodos Geral
   public double calcularIMC(){
        double IMC = 0;
        IMC = Peso/(Altura * Altura); 
        return IMC;
    } 
   
   public string TabelaIMC(){
        double IMC = 0;
        string TabelaDados = " ";
        IMC = Peso/(Altura * Altura); 
        
        if(IMC < 18.5){
            return TabelaDados = "BAIXO";
        }else if(IMC >= 18.5 && IMC < 25){
            return TabelaDados = "NORMAL";
        }else if(IMC >= 25){
            return TabelaDados = "ALTO";
        }else{
            return TabelaDados;
        }
    }
   
   public int Engordar(){
        if(Peso < 50){
            Peso ++;
        }
        return Peso;
    }
    
    public int Emagrecer(){
         if(Peso > 90){
            Peso --;
        }
        return Peso;
    }

   //Destructor
   ~Pessoa()
   {
     
   } 


   public static void Main()
   {
    string Nome;
    int Peso;
    double Altura;
    
    Console.WriteLine("Olá!\nPor favor insira as informações a seguir:");
      
    try{
    Console.Write ("Digite seu nome:\n");
    Nome = Console.ReadLine ();

    Console.Write ("Digite seu peso:\n");
    Peso =  int.Parse(Console.ReadLine ());

    Console.Write ("Digite sua altura:\n");
    Altura = double.Parse(Console.ReadLine ());

      
        Pessoa pessoaA = new Pessoa(Nome, Altura, Peso);
       
        Console.WriteLine("O nome: {0}", pessoaA.getNome());
        Console.WriteLine("O peso: {0}",  pessoaA.getPeso()); 
        Console.WriteLine("A altura: {0}", pessoaA.getAltura()); 
           
        Console.WriteLine(pessoaA.getNome() + "O valor do IMC é:{0}", + pessoaA.calcularIMC()); 
        Console.WriteLine("O IMC está: {0}", pessoaA.TabelaIMC());
            
        Console.WriteLine("\nRecomendações:");
        
        Console.WriteLine(pessoaA.getNome() + " seu peso ideal é:" + pessoaA.Engordar(), " Kg");
            
        Console.WriteLine(pessoaA.getNome() + " seu peso ideal é: " + pessoaA.Emagrecer(), " Kg");
     
     
      }  catch(FormatException){ 
          Console.WriteLine("Formato de entrada errado!");
        }

    
   }

 }

}
