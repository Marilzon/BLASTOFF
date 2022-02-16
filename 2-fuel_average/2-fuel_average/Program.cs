using System;
/*
    Dada a distância A e o combustível gasto B, 
    faça um algoritmo para calcular o consumo médio.
*/
namespace fuel_average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 2: Calculando o gasto de combustivel percorrido");
            GetFuelAverage();
        }

        static void GetFuelAverage()
        {
            double distance, consumption, volume;

            Console.Write("Digite a distancia percorrida: ");
            distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o quantidade de combustivel gasto: ");
            volume = Convert.ToDouble(Console.ReadLine());

            consumption = distance / volume;

            Console.WriteLine("Seu consumo medio e: {0} Litros por KM.", consumption);
        }
    }
}