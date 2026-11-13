using System;

namespace BasicoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Digite um numero: ");
           int a = int.Parse(Console.ReadLine());
           
           Console.WriteLine("Digite um numero: ");
           int b = int.Parse(Console.ReadLine());

           if (a % b == 0 || b % a == 0) {
            Console.WriteLine("Sao multiplos!");
           } else {
                Console.WriteLine("Nao sao multiplos.");
            }
        }
    }
}
