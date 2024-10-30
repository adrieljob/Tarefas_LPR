using System;

namespace ExercicioRetangulo
{
    class Retangulo
    {
        // Atributos
        public double Altura { get; set; }
        public double Largura { get; set; }

        // Construtor
        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        // Método para calcular a área do retângulo
        public double CalcArea()
        {
            return Altura * Largura;
        }

        // Método para calcular o perímetro do retângulo
        public double CalcPerimetro()
        {
            return 2 * (Altura + Largura);
        }

        // Método para exibir os dados do retângulo
        public override string ToString()
        {
            return $"Área: {CalcArea():F2}\nPerímetro: {CalcPerimetro():F2}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Leitura dos valores de altura e largura
            Console.Write("Altura do retângulo: ");
            double altura = double.Parse(Console.ReadLine());
            Console.Write("Largura do retângulo: ");
            double largura = double.Parse(Console.ReadLine());

            // Criação do objeto Retangulo
            Retangulo retangulo = new Retangulo(altura, largura);

            // Exibe a área e o perímetro do retângulo
            Console.WriteLine("\nResultados:");
            Console.WriteLine(retangulo);
        }
    }
}