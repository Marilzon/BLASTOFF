using System;
/*
    Faça um algoritmo que receba um número e retorne a tabuada desse número.
*/
namespace table_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 9: retornar taboada do numero informado.");
            TableCalculator();
        }

        static void TableCalculator()
        {
            int inputValue, i;

            Console.Write("Digite o numero que deseja a taboada: ");
            inputValue = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", inputValue, i, inputValue * i);
            }
        }
    }
}