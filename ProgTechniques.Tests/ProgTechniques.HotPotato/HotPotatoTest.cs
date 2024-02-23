using ProgTechniques.HotPotato;

namespace ProgTechniques.Tests.HotPotato
{
    public class HotPotatoTest
    {
        [Fact]
        public void Fila_Contem_Numero_De_Participantes_Passado_Tet()
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
        [MemberData(nameof(TestData))]
        public void Passes_Ate_Explodir_Estao_Corretos(Queue<string> playersQueue, int passesUntilExplode, string expectedPlayer)
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