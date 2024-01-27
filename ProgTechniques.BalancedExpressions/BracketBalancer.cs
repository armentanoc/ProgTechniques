namespace ProgTechniques.BalancedExpressions
{
    public class BracketBalancer 
    {
        // Ótima aplicação! Combinar estruturas de dados em lógicas como essas é muito comum
        private static readonly Dictionary<char, char> BracketPairs = new Dictionary<char, char>
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        // Boa iniciativa retornando detalhes sobre onde um erro foi encontrado!
        // Quando temos multiplas informações para retornar assim, ao invés do `out` para cada uma das informações (que vai aumentar
        // o número de parametros necessários para o método) costuma-se usar uma classe POCO ou DTO como tipo de retorno.
        // Lá tira o resultado (true or false) e todos os demais detalhes, como por exemplo a lista de todos os brackets que 
        // estão desbalanceados (os de abertura e fechamento)
        public static bool IsExpressionBalanced(string expression, out char mismatchedBracket, out int mismatchedBracketPosition)
        {
            Stack<char> bracketStack = new Stack<char>();
            mismatchedBracket = '\0';
            mismatchedBracketPosition = -1;

            for (int i = 0; i < expression.Length; i++)
            {
                char bracket = expression[i];

                if (IsOpeningBracket(bracket))
                {
                    bracketStack.Push(bracket);
                }
                else if (IsClosingBracket(bracket))
                {
                    if (bracketStack.Count == 0 || !BracketMatches(bracketStack.Pop(), bracket))
                    {
                        mismatchedBracket = bracket;
                        mismatchedBracketPosition = i;
                        return false;
                    }
                }
            }

            return bracketStack.Count == 0;
        }

        private static bool IsOpeningBracket(char bracket)
        {
            return BracketPairs.ContainsKey(bracket);
        }

        private static bool IsClosingBracket(char bracket)
        {
            return BracketPairs.ContainsValue(bracket);
        }

        private static  bool BracketMatches(char openBracket, char closeBracket)
        {
            return BracketPairs[openBracket] == closeBracket;
        }
    }
}