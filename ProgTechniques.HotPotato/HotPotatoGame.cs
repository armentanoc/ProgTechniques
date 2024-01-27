
namespace ProgTechniques.HotPotato
{
    internal class HotPotatoGame
    {
        private static Random _random = new Random();
        internal static void Play(int numberOfPlayers)
        {
            Queue<string> playersQueue = InitializePlayersQueue(numberOfPlayers);
            int passesUntilExplode = GetRandomPassesUntilExplode();

            Console.WriteLine($"Simulando jogo de batata quente com {numberOfPlayers} jogadores.");
            Console.WriteLine($"A batata vai explodir após {passesUntilExplode} passes.");

            PerformPassesUntilExplode(playersQueue, passesUntilExplode);
        }

        static Queue<string> InitializePlayersQueue(int numberOfPlayers)
        {
            var playersQueue = new Queue<string>();

            for (int i = 1; i <= numberOfPlayers; i++)
            {
                playersQueue.Enqueue($"Player {i}");
            }

            return playersQueue;
        }

        static int GetRandomPassesUntilExplode()
        {
            // Esses limites mínimos e máximos aqui seriam uma ótima oportunidade para combinar com o assunto de Configurações. O que acha? ;p
            return _random.Next(1, 101);
        }

        static void PerformPassesUntilExplode(Queue<string> playersQueue, int passesUntilExplode)
        {
            for (int passesCount = 1; passesCount <= passesUntilExplode; passesCount++)
            {
                string currentPlayer = playersQueue.Dequeue();
                Console.WriteLine($"A batata está passando por {currentPlayer} e esse é o passe {passesCount}.");
                playersQueue.Enqueue(currentPlayer);
            }

            string eliminatedPlayer = playersQueue.Dequeue();
            Console.WriteLine($"A batata explodiu! {eliminatedPlayer} está fora do jogo.");
        }
    }
}