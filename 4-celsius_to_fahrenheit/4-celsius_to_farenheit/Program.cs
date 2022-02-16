using System;
/*
    Faça um algoritmo que converta a temperatura de C para F. Utilize a fórmula
*/
namespace celsius_to_fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 4: Converter de CELSIUS para FAHRENHEIT");
            CelsiusToFareNheit();
        }

        static void CelsiusToFareNheit()
        {
            double celsius, fahrenheit;

            Console.WriteLine("Digite a temperatura em CELSIUS: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (celsius * 1.8) + 32;
            Console.WriteLine("Temperatura Celsius {0}, convertida para Fahrennheit retorna: {1}", celsius , fahrenheit);
        }
    }
}

