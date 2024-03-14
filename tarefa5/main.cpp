 #include <iostream>
 #include <string>
 using namespace std;
 int main() {
    int numeroA;
  
  cout<< "Insira um numero inteiro:\n";
  cin >> numeroA;
  
  int numeroB;
  
  cout<< "Insira um numero inteiro:\n";
  cin >> numeroB;
 
     if (numeroA % numeroB == 0){
    cout<< "Os números inseridos são Multiplos"; 
     }
     
      else {
    cout<< "Os números inseridos não são Multiplos"; 
     }
    
     
 }