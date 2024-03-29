﻿
namespace ProgTechniques.HotPotato
{
    public class HotPotatoGame
    {
        internal static void Play(int numberOfPlayers)
        {
            Queue<string> playersQueue = InitializePlayersQueue(numberOfPlayers);
            int passesUntilExplode = GetRandomPassesUntilExplode();

            Console.WriteLine($"Simulando jogo de batata quente com {numberOfPlayers} jogadores.");
            Console.WriteLine($"A batata vai explodir após {passesUntilExplode} passes.");

            PerformPassesUntilExplode(playersQueue, passesUntilExplode);
        }

        public static Queue<string> InitializePlayersQueue(int numberOfPlayers) 
        {
            // 3 
            var playersQueue = new Queue<string>();
       
            for (int i = 1; i <= numberOfPlayers; i++)
            {
                playersQueue.Enqueue($"Player {i}");
            }
            
            return playersQueue;
            // Player 1, Player 2, Player 3
        }

        static int GetRandomPassesUntilExplode()
        {
            return 15;
        }
        
        public static string PerformPassesUntilExplode(Queue<string> playersQueue, int passesUntilExplode) 
        {
            for (int passesCount = 1; passesCount <= passesUntilExplode; passesCount++)
            {
                string currentPlayer = playersQueue.Dequeue();
                Console.WriteLine($"A batata está passando por {currentPlayer}.");
                Console.WriteLine($"Esse é o passe {passesCount}.");
                playersQueue.Enqueue(currentPlayer);
            }

            string eliminatedPlayer = playersQueue.Dequeue();
            Console.WriteLine($"A batata explodiu! {eliminatedPlayer} está fora do jogo.");
            return eliminatedPlayer;
        }
    }
}