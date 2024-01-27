
namespace ProgTechniques.ListFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MIN_LENGTH = 10;

            var input = new[] {
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
            };

            var output = FilterListByMinLength(input, MIN_LENGTH);
            PrintEnumerable(output);

            Console.ReadKey();
        }

        // Entendi a proposta de generalizar e aplicar o conceito, mas entendo que infelizmente o método 
        // abaixo não seria um bom candidato para aplica Generics.
        // Por exemplo:
        // ```
        // var item = 15.ToString() // item vai guardar o valor "15"
        // var result = item.Length >= minLength // result vai guardar o valor false, pois "15".Length == 2
        // ``` 
        // Isso causa confusão de interpretação da finalidade do método e pode levar a bugs.
        // A minha proposta para o método seria:
        internal static IEnumerable<string> FilterListByMinLength(IEnumerable<string> input, int minLength)
        {
            var output = new List<string>();

            foreach (var item in input)
            {
                if (item?.Length >= minLength)
                {
                    output.Add(item);
                }
            }
            return output;
        }

        // Já aqui faz um pouco mais de sentido usar generics, pois não há lógica de decisão envolvida e, no pior dos casos,
        // vai haver uma impressão pouco significativa do objeto, caso o mesmo tenha a implementação padrão do método ToString
        // como seria o caso do seguinte:
        // ```
        // PrintEnumerable(new[] { new int[0], new int[1] });
        // ```
        // A saída seria:
        //
        // Output:
           
        // System.Int32[]
        // System.Int32[]
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
