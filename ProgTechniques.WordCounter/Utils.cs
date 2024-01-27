using System.Text;

namespace ProgTechniques.WordCounter
{
    internal class Utils
    {
        internal static string[] CleanInput(string input)
        {
            return input.WithoutPonctuation().Split();
        }
        internal static IEnumerable<T> CleanInput<T>(IEnumerable<T> input)
        {
            return input;
        }
    }

    public static class Extensions
    {
        // Que tal se implementássemos aqui aquele conceito de métodos de extensão?! Veja como ficaria:
        public static string WithoutPonctuation(this string input)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                if (!char.IsPunctuation(c))
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }
    }
}