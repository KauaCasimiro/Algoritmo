using System;

namespace Algoritmo
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;

            Console.WriteLine("Escreva um número");
            n1 = double.Parse(Console.ReadLine());

            if (n1 < 0 && n1 % 2 == 0)
            {
                Console.WriteLine("O numero é negativo");
                Console.WriteLine("O numero é par");
            } else if (n1 < 0 && n1 % 2 != 0)
            {
                Console.WriteLine("O numero é negativo");
                Console.WriteLine("O numero é impar");
            }
            else if (n1 >= 0 && n1 % 2 == 0)
            {
                Console.WriteLine("O numero é positivo");
                Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O numero é positivo");
                Console.WriteLine("O numero é impar");
            }

        }
    }
}
