using System;
/*
    Faça um algoritmo que recebe uma palavra e retorne se a palavra é palíndromo.
    (Palavra que se pode ler, indiferentemente, da esquerda para direita ou vice-versa. Ex: osso,
    Ana e etc).
*/
namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 14: Checar se a string e um palindromo.\n");
            IsPalindrome();
        }

        static void IsPalindrome()
        {
            Console.Write("Insira a palavra e testaremos se e palindromo: ");
            string? inputString = Console.ReadLine();
            
            char[] inputArray = inputString.ToCharArray();
            Array.Reverse(inputArray);

            string reversedString = new string(inputArray);

            if (inputString.Equals(reversedString, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("{0} e um palindromo.", inputString);
            } else
            {
                Console.WriteLine("{0} não é um palindromo.", inputString);
            }
        }
    }
}
