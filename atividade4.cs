using System;

namespace BasicoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int duracao = 1;

            Console.WriteLine("Digite a hora inicial do jogo: \n");
            int tempo1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a hora em que o jogo acabou: \n");
            int tempo2 = int.Parse(Console.ReadLine());

            if (tempo1 < tempo2 || tempo2 < tempo1) {
                duracao = tempo1 - tempo2;
            } else {
                duracao = 24 - (tempo1 + tempo2);
            }

            Console.WriteLine("O jogo durou: " + duracao + " horas.");
        }
        
    }
}
