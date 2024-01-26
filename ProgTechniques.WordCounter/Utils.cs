using System.Text;

namespace ProgTechniques.WordCounter
{
    internal class Utils
    {
        internal static string[] CleanInput(string input)
        {
            return ReplacePunctuation(input).Split();
        }
        internal static IEnumerable<T> CleanInput<T>(IEnumerable<T> input)
        {
            return input;
        }
        internal static string ReplacePunctuation(string input)
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