using System;
using System.Linq;
/*
    Dada as idades I, J, K, X, Y. Faça um algoritmo para calcular a média das idades.
*/
namespace age_average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 1: Calculando idade media de 5 variaveis");
            GetAgeAverage();
        }

        static void GetAgeAverage()
        {
            int I, J, K, X, Y;

            Console.Write("Digite a idade da variavel I: ");
            I = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a idade da variavel J: ");
            J = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a idade da variavel K: ");
            K = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a idade da variavel X: ");
            X = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a idade da variavel Y: ");
            Y = Convert.ToInt32(Console.ReadLine());

            List<int> ages = new List<int> { I, J, K, X, Y };

            double average = ages.AsQueryable().Average();

            Console.WriteLine("A media das idades e {0}.", average);
        }
    }
}