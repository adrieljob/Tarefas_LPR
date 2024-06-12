using System;
class Program
{
    static void Main()
    {
        // Definindo a matriz de distâncias
        int[,] distancias = {
            { 0, 524, 521, 882 },
            { 524, 0, 434, 586 },
            { 521, 434, 0, 429 },
            { 882, 586, 429, 0 }
        };

        string[] cidades = { "Vitória", "Belo Horizonte", "Rio de Janeiro", "São Paulo" };

        while (true)
        {
            Console.WriteLine("Escolha a cidade de origem:");
            for (int i = 0; i < cidades.Length; i++)
            {
                Console.WriteLine($"{i} - {cidades[i]}");
            }

            int origem = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a cidade de destino:");
            for (int i = 0; i < cidades.Length; i++)
            {
                Console.WriteLine($"{i} - {cidades[i]}");
            }

            int destino = int.Parse(Console.ReadLine());

            if (origem == destino)
            {
                Console.WriteLine("Programa encerrado.");
                break;
            }

            int distancia = distancias[origem, destino];
            Console.WriteLine($"A distância entre {cidades[origem]} e {cidades[destino]} é de {distancia} km.");
        }
    }
}
