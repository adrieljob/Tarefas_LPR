#include <iostream>
#include <array>
 
int numeros[10]={5,8,7,9,6,4,10,8,10,9};
 
int main()
{
    for (int i=0; i<=10; i++){
      if (numeros[i]%2==0){
         std::cout<<"os numeros pares estão nas posições " << numeros[i] << std::endl;
      }
      else if (numeros[i]%2==1){
         std::cout<<"os numeros impares estão nas posições " << numeros[i] << std::endl;
      }
    }
    return 0;
}