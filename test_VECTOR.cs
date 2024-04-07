using System;
using System.Globalization;

class Program {
  public static void Main (string[] args) {
    CultureInfo CI = CultureInfo.InvariantCulture;
    int N,i;
    
    
    Console.Write("Digite o valor do vetor: ");
    N = int.Parse(Console.ReadLine());

    double[] vet = new double [N];

    for(i = 0; i < N; i++){
      Console.WriteLine("Vet ["+i+"]: ");
      vet[i] = double.Parse(Console.ReadLine());
    }

    Console.WriteLine("VETORES:");
    Console.WriteLine();
    
    for(i = 0; i < N; i++){
      Console.WriteLine(vet[i].ToString("F1",CI));
    }

    
  }
}