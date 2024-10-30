using System;

namespace ExercicioAluno
{
    class Aluno
    {
        // Atributos
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public double NotaProva1 { get; set; }
        public double NotaProva2 { get; set; }
        public double NotaTrabalho { get; set; }

        // Construtor
        public Aluno(int matricula, string nome, double notaProva1, double notaProva2, double notaTrabalho)
        {
            Matricula = matricula;
            Nome = nome;
            NotaProva1 = notaProva1;
            NotaProva2 = notaProva2;
            NotaTrabalho = notaTrabalho;
        }

        // Método para calcular a média final
        public double Media()
        {
            // Cada prova tem peso 2,5 e o trabalho tem peso 2
            double media = (NotaProva1 * 2.5 + NotaProva2 * 2.5 + NotaTrabalho * 2) / 7;
            return media;
        }

        // Método para calcular quanto o aluno precisa para a prova final
        public double NotaParaFinal()
        {
            double mediaFinal = Media();
            double mediaMinima = 5.0;

            if (mediaFinal >= mediaMinima)
            {
                return 0; // Aluno não precisa fazer a prova final
            }
            else
            {
                // Nota necessária na prova final para atingir média 5
                double notaNecessaria = (mediaMinima * 2) - mediaFinal;
                return notaNecessaria > 10 ? 10 : notaNecessaria; // Máximo de 10
            }
        }

        // Método para exibir os dados do aluno e a média final
        public override string ToString()
        {
            return $"Matrícula: {Matricula}\nNome: {Nome}\nMédia Final: {Media():F2}\nNota para a Final: {NotaParaFinal():F2}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Leitura dos dados do aluno
            Console.Write("Matrícula: ");
            int matricula = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nota da Prova 1: ");
            double notaProva1 = double.Parse(Console.ReadLine());
            Console.Write("Nota da Prova 2: ");
            double notaProva2 = double.Parse(Console.ReadLine());
            Console.Write("Nota do Trabalho: ");
            double notaTrabalho = double.Parse(Console.ReadLine());

            // Criação do objeto Aluno
            Aluno aluno = new Aluno(matricula, nome, notaProva1, notaProva2, notaTrabalho);

            // Exibe os dados do aluno, média final e nota para a prova final
            Console.WriteLine("\nDados do Aluno:");
            Console.WriteLine(aluno);
        }
    }
}