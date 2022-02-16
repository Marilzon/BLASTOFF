using System;
using System.Linq;
/*
    - Dada duas lista de números A[1,2,3,4] e B[1,2,5,8], 
    faça um algoritmo que retorne a concatenação das listas
*/
namespace concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            GetIntersection();
        }

        static void GetIntersection()
        {
            int[] A = { 1, 2, 3, 4 };
            int[] B = { 1, 2, 5, 8 };
            
            Console.WriteLine("Array A: [1, 2, 3, 4]");
            Console.WriteLine("Array B: [1, 2, 5, 8]\n");

            IEnumerable<int> concatenateVectors = A.Concat(B);

            Console.Write("Retorno da concatenação: ");
            Console.WriteLine(String.Join(",", concatenateVectors));
        }
    }
}
