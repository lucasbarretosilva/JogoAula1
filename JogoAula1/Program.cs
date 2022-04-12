using System;

namespace JogoAula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = new Random().Next(0,10);
            Console.Write("Adivinhe o número que estou pensando (de 0 a 10): " );
            int num = int.Parse( Console.ReadLine() );
            if(num > 10 || num < 0)
            {
                Console.WriteLine("Número inválido! Coloque um número de 0 a 10!");
                num = int.Parse( Console.ReadLine() );
            }
            else
            {
                if(num == input)
                {
                    Console.WriteLine("Acertou mizeravi!");
                }
            }
        }
    }
}
