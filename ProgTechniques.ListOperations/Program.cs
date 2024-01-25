

namespace ProgTechniques.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MIN_LENGTH = 10;

            var input =
                GenericValues<string>
                .GenerateList
                (
                "Idiossincrasia",
                "Ambivalente",
                "Quimérica",
                "Perpendicular",
                "Efêmero",
                "Pletora",
                "Obnubilado",
                "Xilografia",
                "Quixote",
                "Inefável"
                );

            //var input =
            //    GenericValues<long>
            //    .GenerateList
            //    (
            //    12345678912,
            //    1234567812,
            //    123,
            //    12,
            //    12345678912345,
            //    12345,
            //    124467689790
            //    );

            var output = FilterListByMinLength(input, MIN_LENGTH);
            PrintEnumerable(output);

            Console.ReadKey();
        }

        internal static List<T> FilterListByMinLength<T>(List<T> input, int minLength)
        {
            var output = new List<T>();

            foreach (var item in input)
            {
                if (item.ToString().Length >= minLength)
                {
                    output.Add(item);
                }
            }
            return output;
        }

        internal static void PrintEnumerable<T>(IEnumerable<T> items)
        {
            Console.WriteLine("Output: \n");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
