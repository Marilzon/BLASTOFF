using System;
/*
    Dada uma lista de números A[1,2,3,…], faça um algoritmo que retorne uma lista somente
    com os números pares.
*/
namespace only_pair
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 7: Retornar numeros pares de uma lista.");
            OnlyPair();
        }

        static void OnlyPair()
        {
            Console.Write("Insira o tamanho do array que vamos trabalhar: ");
            int sizeOfArray = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[sizeOfArray];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Digite o valor da posicao {0}: ", i);
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Os valores pares informados são: ");
            foreach (int item in myArray)
            {                
                if (item % 2 == 0)
                {
                    Console.Write("{0} ", item);
                }
            }
        }
    }
}
