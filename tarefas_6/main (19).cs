using System;
class HelloWorld {
  static void Main() {
      double total;
      double soma = 0;
      double quantidade = 0;
      int contador = 0;
        
    Console.WriteLine("Insira a quantidade de numeros que serão digitados");
    int quantidade_nums = int.Parse(Console.ReadLine());
        
      while (contador < quantidade_nums){
        Console.WriteLine("Insira um numero à ser analisado");
       int numero_analisado = int.Parse(Console.ReadLine());
       
            if (numero_analisado % 2 == 0){
            soma += numero_analisado;
            quantidade++;
            }
            contador++;
        }
        
        total = soma / quantidade;
        
    Console.WriteLine("A media dos numeros inseridos é " + total);
    }
}
