using System;

 public struct compras{
 public string nome;
 public int codigo;
 public int preco;
 public int quantidade;
 } 

class HelloWorld {
  static void Main() {
      int total=0;
      
      compras[] itens = new compras[3];
      
      for(int i=0 ; i<3 ; i++){
        Console.WriteLine("Digite o nome do produto: ");
        itens[i].nome = Console.ReadLine();
        Console.WriteLine("Digite o código do produto: ");
        itens[i].codigo = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o preço do produto: ");
        itens[i].preco = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de produto(s): ");
        itens[i].quantidade = int.Parse(Console.ReadLine());
      }
      total= itens[0].preco * itens[0].quantidade + itens[1].preco * itens[1].quantidade + itens[2].preco * itens[2].quantidade;
      Console.WriteLine("O valor total em estoque é:" + total);
  }
}
