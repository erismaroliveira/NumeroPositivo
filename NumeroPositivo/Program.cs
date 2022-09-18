/*
* Programa C# para aceitar um número do usuário e exibi-lo se for positivo
*/

using System;

namespace NumeroPositivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("O número é positivo");
            }
            else if (numero == 0)
            {
                Console.WriteLine("O número é 0");
            }
            else
            {
                Console.WriteLine("O número é negativo");
            }

            Console.ReadLine();
        }
    }
}