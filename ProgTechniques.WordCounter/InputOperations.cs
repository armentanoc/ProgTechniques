namespace ProgTechniques.WordCounter
{
    internal class InputOperations
    {
        // Ótima aplicação de generalização!
        internal static Dictionary<T, int> CountOccurrences<T>(IEnumerable<T> input) where T : notnull
        {
            Dictionary<T, int> occurrences = new();

            foreach (var element in input)
            {
                if (occurrences.ContainsKey(element))
                {
                    occurrences[element]++;
                }
                else
                {
                    occurrences[element] = 1;
                }
            }

            return occurrences;
        }
        internal static void DisplayOccurrences<T>(Dictionary<T, int> occurrences)
        {
            var sortedOccurrences = occurrences.OrderByDescending(kv => kv.Value);

            foreach (var kvp in sortedOccurrences)
            {
                Console.WriteLine($"Item: {kvp.Key} => Occurrences: {kvp.Value}");
            }
        }
    }
}