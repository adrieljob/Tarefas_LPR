using System;
class HelloWorld {
  static void Main() {
      double total;
      double soma = 0;
      int contador = 1, quantidade_nums, numero_analisado;
        
    Console.WriteLine("Insira a quantidade de numeros que serão digitados");
    quantidade_nums = int.Parse(Console.ReadLine());
        
      while (contador <= quantidade_nums){
        Console.WriteLine("Insira um numero à ser analisado");
        numero_analisado = int.Parse(Console.ReadLine());
       
            if (numero_analisado % 2 == 0){
            soma += numero_analisado;
            }
            contador++;
        }
        
        total = soma / quantidade_nums;
        
    Console.WriteLine("A media dos numeros inseridos é " + total);
    }
}