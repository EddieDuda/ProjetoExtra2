using System;

    //Crie um novo programa C# chamado SempreEmForma.
namespace SempreEmForma 
{ 
    //Crie uma classe vazia chamada Pessoa.
    //Adicione à classe os atributos peso (valor inteiro) e altura (valor decimal).
//Configure a acessibilidade dos atributos e métodos da classe, de forma que: 
//todos os atributos sejam privados 
//Adicione um novo atributo à classe Pessoa, chamado nome.
 public class Pessoa
 {
   private string Nome;
   private int Peso;
   private double Altura;
  
   //Crie um método construtor para a classe.
   //Altere o construtor para contemplar o nome da pessoa.
   Pessoa(string Nome, double Altura,int Peso)
   {
     this.Nome   = Nome;
     this.Altura = Altura;
     this.Peso = Peso;
   } 
//e todos os métodos sejam públicos.
//Inclua os métodos get e set do atributo nome.
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
     
   //Crie um método para calcular o IMC da pessoa 
   public double calcularIMC(){
        double IMC = 0;
        IMC = Peso/(Altura * Altura); 
        return IMC;
    } 
   //Inclua um método na classe Pessoa que faça uma avaliação do IMC 
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
   //Crie um método para elevar o peso de uma pessoa até um determinado valor.
   public int Engordar(){
        double IMC = 0;
        IMC = Peso/(Altura * Altura); 
        if(IMC < 18.5){
            Peso = Peso + 30;
        }
        return Peso;
    }
    //Crie um método para reduzir o peso de uma pessoa até um determinado valor.
    public int Emagrecer(){
        double IMC = 0;
        IMC = Peso/(Altura * Altura); 
        if(IMC >= 25){
            Peso = Peso - 40;
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
    //Nome:Luan
    Console.WriteLine("Olá!\nPor favor insira as informações a seguir:");
      
    try{
    Console.Write ("Digite seu nome:\n"); //Nome:Luan
    Nome = Console.ReadLine ();

    Console.Write ("Digite seu peso:\n"); //Peso:62
    Peso =  int.Parse(Console.ReadLine ());

    Console.Write ("Digite sua altura:\n"); //Altura: 1.55
    Altura = double.Parse(Console.ReadLine ());

      
        Pessoa pessoaA = new Pessoa(Nome, Altura, Peso);
       
       //Altere o programa principal para perguntar qual o nome, o peso e a altura da 
       //pessoa através do console
       //Altere o programa principal para exibir o nome da pessoa.
        Console.WriteLine("O nome: {0}", pessoaA.getNome());
        //Inclua mais duas mensagens no programa principal para exibir o peso e a altura da pessoa
        Console.WriteLine("O peso: {0}",  pessoaA.getPeso()); 
        Console.WriteLine("A altura: {0}", pessoaA.getAltura()); 
        
        //Altere o programa principal, de forma que ele passe a exibir o IMC da pessoa.   
        Console.WriteLine(pessoaA.getNome() + ", o valor do seu IMC é:{0}", + pessoaA.calcularIMC()); 
        Console.WriteLine("O IMC está: {0}", pessoaA.TabelaIMC());
            
        Console.WriteLine("\nRecomendações:");
        
        if(pessoaA.calcularIMC() < 18.5){
        Console.WriteLine(" Seu peso ideal é:" + pessoaA.Engordar(), " Kg");
        }else if(pessoaA.calcularIMC() >= 25){   
        Console.WriteLine(" Seu peso ideal é: " + pessoaA.Emagrecer(), " Kg");
        }else{
        Console.WriteLine("Está tudo certo. \nContinue cuidando da sua saúde");    
        }
     
      }  catch(FormatException){ 
          Console.WriteLine("Formato de entrada errado!");
        }
    // Implemente tratamento de exceções para valores inválidos de peso e altura.
    
   }

 }

}
