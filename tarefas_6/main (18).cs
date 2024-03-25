using System;
class Program
{
    static void Main()
    {
        Random numAleatorio = new Random();
        int valorInteiro = numAleatorio.Next(1, 101); 

        int tentativas = 0;
        int palpite;

        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
        Console.WriteLine("Tente adivinhar o número inteiro aleatório entre 1 e 100.");

        do
        {
            Console.Write("Insira seu palpite: ");
            palpite = Convert.ToInt32(Console.ReadLine());
            tentativas++;

            if (palpite < valorInteiro)
            {
                Console.WriteLine("Chutou baixo.");
            }
            else if (palpite > valorInteiro)
            {
                Console.WriteLine("Chutou alto.");
            }
            else
            {
                Console.WriteLine($"Parabéns! Você acertou o número {valorInteiro}.");
            }
        }
        while (palpite != valorInteiro);

        Console.WriteLine($"Número de tentativas: {tentativas}");
    }
}
