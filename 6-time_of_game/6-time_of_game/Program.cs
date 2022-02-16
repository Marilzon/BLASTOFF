using System;
/*
    - Uma partida de futebol iniciou na hora A e terminou na hora B. Faça um algoritmo que
    calcule o tempo que durou a partida.
*/
namespace time_of_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 6: Calcular tempo de jogo");
            TimeOfGame();
        }

        static void TimeOfGame()
        {
            string? startGame, endGame;
            string[] startGameToArray, endGameToArray;
            int startGameHour, startGameMinutes, endGameHour, endGameMinutes, totalGameHour, totalGameMinutes;

            Console.Write("Insira o horario que iniciou o jogo no formato(Horas:Minutos): ");
            startGame = Console.ReadLine();

            Console.Write("Insira o horario que o jogo acabou no formato(Horas:Minutos): ");
            endGame = Console.ReadLine();

            startGameToArray = startGame.Split(":");
            endGameToArray = endGame.Split(":");

            startGameHour = Convert.ToInt32(startGameToArray[0]);
            startGameMinutes = Convert.ToInt32(startGameToArray[1]);

            endGameHour = Convert.ToInt32(endGameToArray[0]);
            endGameMinutes = Convert.ToInt32(endGameToArray[1]);

            totalGameHour = ( endGameHour - startGameHour ) % 24;
            totalGameMinutes = ( endGameMinutes - startGameMinutes) % 60;

            Console.WriteLine("O tempo do jogo foi: {0}:{1} Horas", totalGameHour, totalGameMinutes);
        }
    }
}
