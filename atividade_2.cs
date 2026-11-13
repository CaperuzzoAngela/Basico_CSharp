using System;

namespace BasicoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");

            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0) {
                Console.WriteLine("Numero par!");
            } else {
                Console.WriteLine("Numero impar!");
            }
        }
    }
}
