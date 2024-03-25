#include <iostream>
using namespace std;

int main() {
    int soma = 0;

    for (int num = 50; num <= 500; num++)
        {
            if (num % 2 != 0 && num % 3 == 0)
            {
                soma += num;
            }
        }

    cout << "A soma de todos os números ímpares múltiplos de 3 entre 50 e 500 é: " << soma << endl;

    return 0;
}
