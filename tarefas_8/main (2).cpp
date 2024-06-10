#include <iostream>
#include <array>

int numeros[10] = {5, 8, 7, 9, 6, 4, 10, 8, 10, 9};
int num;

int main() {
    std::cout << "Insira um numero para ver se existe no vetor: ";
    std::cin >> num;
    
    int vezes = 0;
    for (int i = 0; i < 10; i++) {
        if (num == numeros[i]) {
            vezes++;
            std::cout << "O numero " << num << " aparece na posição " << i << std::endl;
        }
    }
    if (vezes == 0) {
        std::cout << "O numero " << num << " nao aparece no vetor." << std::endl;
    } 
    else {
        std::cout << "O numero " << num << " aparece " << vezes << " vezes no vetor." << std::endl;
    }
    
    return 0;
}
