using System;
using System.Linq;
/*
    Dada duas lista de números A[1,2,3,4] e B[1,2,5,8], 
    faça um algoritmo que retorne aintersecção das listas
*/
namespace intersection
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

            IEnumerable<int> intersectVectors = A.Intersect(B);

            Console.Write("Retorno da Intersecção: ");

            Console.WriteLine(String.Join(",", intersectVectors));
        }
    }
}