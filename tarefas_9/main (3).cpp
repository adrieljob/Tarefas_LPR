#include <iostream>
#include <array>
struct Livro{
std::string Titulo;
std::string Autor;
int AnoPublicacao;
int NumeroPaginas;
int Preco;
};

int main()
{
int PrecoTotal=0;
int MediaPaginas=0;
int MediaPaginasFinal;

std::array<Livro, 3> livros;
for(int i=0 ; i<3 ; i++){
std::cout << "Insira o título do livro: ";
std::cin.ignore();
std::getline(std::cin, livros[i].Titulo);
        
std::cout << "Insira o autor do livro: ";
std::getline(std::cin, livros[i].Autor);

std::cout << "Insira o ano de publicação do livro: ";
std::cin >> livros[i].AnoPublicacao;

std::cout << "Insira o numero de páginas do livro: ";
std::cin >> livros[i].NumeroPaginas;

std::cout << "Insira o preço do livro: ";
std::cin >> livros[i].Preco;
}
PrecoTotal = livros[0].Preco + livros[1].Preco + livros[2].Preco;
MediaPaginas = livros[0].NumeroPaginas + livros[1].NumeroPaginas + livros[2].NumeroPaginas;
MediaPaginasFinal = MediaPaginas / 3;
 
 std::cout<<"O preço total dos livros é de " << PrecoTotal << " reais " <<  std::endl;
 std::cout<<"A media de paginas dos livros é de " << MediaPaginasFinal << " páginas "  << std::endl;

return 0;
}