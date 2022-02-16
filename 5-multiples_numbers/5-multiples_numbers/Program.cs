using System;
/*
    Faça um algoritmo para apresentar se dois números são múltiplos
*/
namespace multiple_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 5: Checar se 2 numeros são multiplos");
            multipleNumbers();
        }

        static void multipleNumbers()
        {
            double a, b;

            Console.WriteLine("Digite o primeiro numero: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            b = Convert.ToDouble(Console.ReadLine());
            
            if ( a % b == 0 | b % a == 0)
            {
                Console.WriteLine("{0} e multiplo de {1}", a, b);
            } else
            {
                Console.WriteLine("{0} nao multiplo de {1}", a, b);
            }
        }
    }
}
