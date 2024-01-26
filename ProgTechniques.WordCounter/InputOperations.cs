namespace ProgTechniques.WordCounter
{
    internal class InputOperations
    {
        internal static Dictionary<T, int> CountOccurrences<T>(IEnumerable<T> input)
        {
            Dictionary<T, int> occurrences = new Dictionary<T, int>();

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