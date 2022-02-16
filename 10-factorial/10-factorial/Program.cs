using System;
/*
    Faça um algoritmo que receba um número e retorne o Fatorial desse número.
*/
namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 10: Calcular fatorial.");
            GetFactorial();
        }

        static void GetFactorial()
        {
            int inputValue, factorial = 1;

            Console.Write("Digite o valor a retornar fatorial: ");
            inputValue = Convert.ToInt32(Console.ReadLine());

            if (inputValue != 0)
            {
                for (int i = 1;i <= inputValue; i++)
                {
                    factorial = factorial * i;
                }
            }

            Console.WriteLine("Fatorial de {0} é: {1}", inputValue, factorial);
        }
    }
}

