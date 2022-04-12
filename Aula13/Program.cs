using System;

namespace Aula13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = new Random().Next(1,5);
            Console.Write("Digite um número entre 1 e 5:");
            int num = int.Parse(Console.ReadLine());

            if(num == input)
            {
                Console.WriteLine("Parabéns acertou!");
            }
            else
            {
                Console.WriteLine("errou");
            }

        }
    }
}
