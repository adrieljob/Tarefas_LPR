using System;
 public struct cadastrarHeroi{
 public string nome;
 public string poder;
 public int pontuacao;
 } 

class HelloWorld {
    static cadastrarHeroi[] Heroi = new cadastrarHeroi[5];
  static void Main() {
        Menu();
      }
        
        static void Menu()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nSelecione uma opção:");
            Console.WriteLine("1 = Cadastro de heróis");
            Console.WriteLine("2 = Seleção de equipe");
            Console.WriteLine("3 = Exibição da equipe");
            Console.WriteLine("4 = Sair");

            if (int.TryParse(Console.ReadLine(), out int opcao))
            {
                switch (opcao)
                {
                    case 1:
                        CadastroHerois();
                        break;
                    case 2:
                        SelecaoEquipe();
                        break;
                    case 3:
                        ExibicaoEquipe();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }
            }
        }
    }
      
      static void CadastroHerois(){
          
     Console.WriteLine("\nVocê selecionou a Opção Cadastro de heróis");

      for(int i=0 ; i<5 ; i++){
        Console.WriteLine("Digite o nome do heroi: ");
        Heroi[i].nome = Console.ReadLine();
        Console.WriteLine("Digite o poder do heroi: ");
        Heroi[i].poder = Console.ReadLine();
        Console.WriteLine("Digite a pontuação do heroi: ");
        Heroi[i].pontuacao = int.Parse(Console.ReadLine());
      }
    }
      static void SelecaoEquipe()
    {
        Console.WriteLine("\nVocê selecionou a Opção SeleCão de equipe");

        Console.WriteLine("Lista de Heróis Cadastrados:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Nome: {Heroi[i].nome}, Poder: {Heroi[i].poder}, Pontuação: {Heroi[i].pontuacao}");
        }


    }
 
       static void ExibicaoEquipe(){
        Console.WriteLine("Você selecionou a Opção Exibição da equipe");
        calcularPontuacaoTotal();   
       }
       
        static void calcularPontuacaoTotal(){

        }
 
  }