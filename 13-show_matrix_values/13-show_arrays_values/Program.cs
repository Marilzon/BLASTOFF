using System;
using System.Linq;
/*
    - Faça um algoritmo que receba uma matriz[i,z] como parâmetro e imprima todos os
    valores dessa matriz

    Usei a nomeacao LINGUAGEM, RELEASE pois eu consigo ter uma abstracao mais clara do que i, z, buscando
    um codigo extremamente auto explicativo
*/
namespace show_matrix_values
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 13: Retornar valores da matriz[linguagem,release].\n");
            Showlanguages();
        }

        static void Showlanguages()
        {
            string[,] languages = new string[3, 2];
            string language = "";

            languages[0, 0] = "C#";
            languages[0, 1] = "2000";

            languages[1, 0] = "PYTHON";
            languages[1, 1] = "1991";

            languages[2, 0] = "JAVASCRIPT";
            languages[2, 1] = "1995";

            for (int row = 0; row < 3;row++)
            {
                for (int column = 0; column < 2; column++)
                {
                    language += languages[row, column] + ": ";
                }
                Console.WriteLine(language);
                language = ""; // cleaning variable
            }
        }
    }
}
