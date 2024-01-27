
namespace ProgTechniques.WordCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla auctor porta velit a tincidunt. Nam efficitur iaculis placerat. Aenean lectus dui, sollicitudin id rhoncus tristique, aliquet sed quam. Phasellus blandit magna at elementum consequat. Nam vitae nunc vehicula, blandit felis a, placerat augue. Quisque bibendum a ipsum at scelerisque. Duis molestie turpis quis orci vehicula aliquam. Duis non elementum erat. Phasellus et dui odio. Nunc vitae leo sem. Curabitur nec enim id mi aliquet commodo at et sapien. Fusce sit amet nisi elit. Interdum et malesuada fames ac ante ipsum primis in faucibus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Duis vitae dolor at sem ultrices euismod. Morbi aliquet, felis et mattis congue, justo nunc pharetra lectus, a lobortis mauris eros et nulla.";
            //List<int> input = new List<int> { 1, 2, 3, 1, 2, 3, 4, 5 };
            //char[] input = "Hello, World!".ToCharArray(); 

            var cleanedInput = Utils.CleanInput(input);
            var dictInputCount = InputOperations.CountOccurrences(cleanedInput);

            // Nota como tivemos que sair do objeto InputOperations com o resultado e voltar para ele para pedir para imprimir?
            // Isso pode ser interpretado como um sinal de o método DisplayOccurrences não deveria estar lá dentro, mas sim aqui fora (ou em outro objeto)
            InputOperations.DisplayOccurrences(dictInputCount);

            Console.ReadLine();
        }
    }
}