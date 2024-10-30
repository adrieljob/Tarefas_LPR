using System;

namespace ExercicioFuncionario
{
    class Funcionario
    {
        // Atributos
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; private set; }

        // Construtor
        public Funcionario(string nome, double salarioBruto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            CalcularImposto();
        }

        // Método para calcular o imposto com base na tabela
        private void CalcularImposto()
        {
            if (SalarioBruto <= 2000)
            {
                Imposto = SalarioBruto * 0.10;
            }
            else if (SalarioBruto <= 3000)
            {
                Imposto = SalarioBruto * 0.15;
            }
            else
            {
                Imposto = SalarioBruto * 0.20;
            }
        }

        // Método para calcular o salário líquido
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        // Método para aumentar o salário com base em uma porcentagem
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem / 100);
            CalcularImposto(); // Recalcula o imposto após o aumento
        }

        // Método para exibir os dados do funcionário
        public override string ToString()
        {
            return $"Nome: {Nome}\nSalário Líquido: {SalarioLiquido():F2}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Leitura dos dados do funcionário
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine());

            // Criação do objeto Funcionario
            Funcionario funcionario = new Funcionario(nome, salarioBruto);

            // Exibe os dados iniciais do funcionário
            Console.WriteLine("\nDados do Funcionário:");
            Console.WriteLine(funcionario);

            // Aumento do salário
            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
            funcionario.AumentarSalario(porcentagem);

            // Exibe os dados do funcionário após o aumento
            Console.WriteLine("\nDados Atualizados:");
            Console.WriteLine(funcionario);
        }
    }
}