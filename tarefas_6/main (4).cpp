#include <iostream>
#include <string>

using namespace std;

int main() {
    int numero;
    cout << "Insira um número: ";
    cin >> numero;

    int quadrado = numero * numero;

    int somaDigitos = 0;

    string quadradoStr = to_string(quadrado);
    for (int i = 0; i < quadradoStr.length(); i++) {
        somaDigitos += quadradoStr[i] - '0';
    }

    cout << "A soma dos dígitos do quadrado do número fornecido é: " << somaDigitos << endl;

    return 0;
}
