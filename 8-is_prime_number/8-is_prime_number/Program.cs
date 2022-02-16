using System;
/*
    Faça um algoritmo que receba um número e retorne se o número é primo ou não.
*/
namespace is_prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 8: Checar numero se e numero primo");
            PrimeNumberCheck();
        }

        static void PrimeNumberCheck()
        {
            int i, inputValue;

            Console.Write("Digite o numero que deseja verificar se e primo: ");
            inputValue = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= inputValue - 1; i++)
            {
                if ( inputValue % i == 0 )
                {
                    Console.WriteLine("O numero {0} nao e primo", inputValue);
                    break;
                }
            }
            if (i == inputValue)
            {
                Console.WriteLine("O numero {0} e primo", inputValue);
            }
        }
    }
}