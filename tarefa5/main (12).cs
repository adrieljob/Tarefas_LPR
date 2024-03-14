using System;
class HelloWorld {
  static void Main() {
    
    int numero;

    Console.WriteLine("Insira um número inteiro:");
    numero = int.Parse(Console.ReadLine());
    
     if(numero % 2 == 0){
      Console.WriteLine("O número inserido é \nPAR");
     }
     else {
      Console.WriteLine("O número inserido é \nIMPAR");
     }
  }
}