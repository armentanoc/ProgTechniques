using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTechniques.BalancedExpressions
{
    public class BracketBalancer 
    {
        private static readonly Dictionary<char, char> BracketPairs = new Dictionary<char, char>
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

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