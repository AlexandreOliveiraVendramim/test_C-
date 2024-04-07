using System;
using System.Globalization;

class Program {
  public static void Main (string[] args) {
    CultureInfo CI = CultureInfo.InvariantCulture;

    int N,i,cont;
    
    Console.WriteLine ("Digite o valor: ");
    N = int.Parse(Console.ReadLine());

    cont = 0;
    for (i = 1; i <= N; i++){
      if(N % i == 0){
        cont = cont + 1;
      }
    }

    if(cont == 2){
      Console.Write("O valor é primo");
    }
    else{
      Console.Write("O valor não é primo");
    }
  }
}