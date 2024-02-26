using ProgTechniques.HotPotato;

namespace ProgTechniques.Tests.HotPotato
{
    public class HotPotatoTest
    {
        [Fact]
        public void Fila_Contem_Numero_De_Participantes_Passado_Test()
        {
            //Arrange
            var tamanhoListaParticipante = 3;

            //Act
            var result = HotPotatoGame.InitializePlayersQueue(tamanhoListaParticipante);

            //Assert
            Assert.True(result.Count == tamanhoListaParticipante);
        }

        [Fact]
        public void Primeiro_Da_Fila_Eh_Player_Um_Test()
        {
            //Arrange
            var tamanhoListaParticipante = 5;

            //Act
            var result = HotPotatoGame.InitializePlayersQueue(tamanhoListaParticipante);

            //Assert
            Assert.True(result.Peek() == $"Player 1");
        }

        [Fact]
        public void Ultimo_Da_Fila_Eh_Player_Passado_Test()
        {
            //Arrange
            var tamanhoListaParticipante = 6;

            //Act
            var result = HotPotatoGame.InitializePlayersQueue(tamanhoListaParticipante);

            //Assert
            Assert.True(result.Last() == $"Player {tamanhoListaParticipante}");
        }

        [Theory]
        [MemberData(nameof(Fila_Test))]
        public void Player_Retornado_Eh_O_Que_Explodiu_Test(Queue<string> filaJogadores, int numeroPassesAteExplodir, string perdedorEsperado)
        {
            //Arrange, Act
            string resultado = HotPotatoGame.PerformPassesUntilExplode(filaJogadores, numeroPassesAteExplodir);

            //Assert
            Assert.Equal(resultado, perdedorEsperado);
        }

        public static IEnumerable<object[]> Fila_Test()
        {
            yield return new object[] { new Queue<string>(new[] { "Player 1", "Player 2" }), 3, "Player 2" };
            yield return new object[] { new Queue<string>(new[] { "Player 1", "Player 2", "Player 3" }), 5, "Player 3" };
        }
























        [Theory]
        [MemberData(nameof(TestData))]
        public void Passes_Ate_Explodir_Estao_Corretos_Test(Queue<string> playersQueue, int passesUntilExplode, string expectedPlayer)
        {
            //Arrange, Act
            var result = HotPotatoGame.PerformPassesUntilExplode(playersQueue, passesUntilExplode);

            //Assert
            Assert.Equal(expectedPlayer, result);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { new Queue<string>(new[] { "Player 1", "Player 2" }), 3, "Player 2" };
            yield return new object[] { new Queue<string>(new[] { "Player 1", "Player 2", "Player 3" }), 5, "Player 3" };
        }
    }
}