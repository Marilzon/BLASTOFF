using System;
using System.Linq;
/*
    Dados três números (a, b, c), faça um algoritmo para mostrar o menor número.
*/
namespace min_value
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 3: Exibindo menor valor");
            ShowMinValue();
        }

        static void ShowMinValue()
        {
            int a, b, c;

            Console.Write("Digite o primeiro valor: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            c = Convert.ToInt32(Console.ReadLine());

            List<int> values = new List<int> { a, b, c };

            int lowerValue = values.AsQueryable().Min();

            Console.WriteLine("O menor valor é: {0}", lowerValue);
        }
    }
}
