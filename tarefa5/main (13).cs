using System;
class HelloWorld {
  static void Main() {
   
   int escolha;
   
    Console.WriteLine("Selecione sua classe para o jogo:\n1=Guerreira 2=Mago 3=Arqueira");
    escolha = Convert.ToInt32(Console.ReadLine());
    
    switch (escolha) {
    case 1:
    escolha = 1;
    Console.WriteLine("Ataque Pesado, Defesa Total");

    break;
    case 2:
    escolha = 2;
    Console.WriteLine("Bola de Fogo, Escudo de Gelo");

    break;
    case 3:
    escolha = 3;
    Console.WriteLine("Flecha Precisa, Disparo Triplo");

    break;
    default:
    Console.WriteLine("Opção inválida");
    break;
 }
  }
}