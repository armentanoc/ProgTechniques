using ProgTechniques.BalancedExpressions;
public class Program
{
    public static void Main()
    {
        string balancedExpression1 = "(2+1)*80/(7-[√9 + {4² * 0}])";
        string balancedExpression2 = "{[()]()}";
        string balancedExpression3 = "[[[]]]";

        string unbalancedExpression1 = "([{35 - 2} + 5*3} + 0 / 15) - [3 + 5³] * 11)";
        string unbalancedExpression2 = "{[([)]}";
        string unbalancedExpression3 = "[[[(]]]";

        Console.WriteLine("A equação está balanceada?");

        PrintBalanceResult(balancedExpression1); //true
        PrintBalanceResult(balancedExpression2); //true
        PrintBalanceResult(balancedExpression3); //true

        PrintBalanceResult(unbalancedExpression1); //false
        PrintBalanceResult(unbalancedExpression2); //false
        PrintBalanceResult(unbalancedExpression3); //false

        Console.ReadLine();
    }

    public static void PrintBalanceResult(string expression)
    {
        bool isBalanced = BracketBalancer.IsExpressionBalanced(expression, out char mismatchedBracket, out int mismatchedBracketPosition);

        if (!isBalanced)
        {
            PrintUnbalancedExpression(expression, mismatchedBracket, mismatchedBracketPosition);
        }
        else
        {
            PrintBalancedExpression(expression, isBalanced);
        }
    }

    private static void PrintUnbalancedExpression(string expression, char mismatchedBracket, int mismatchedBracketPosition)
    {
        string beforeMismatch = expression.Substring(0, mismatchedBracketPosition);
        string afterMismatch = expression.Substring(mismatchedBracketPosition + 1);

        Console.WriteLine
            (
            $"\n  {beforeMismatch}" +
            $"\u001b[31m{mismatchedBracket}\u001b[0m" +
            $"{afterMismatch}" +
            $" >> {false}"
            );
    }

    private static void PrintBalancedExpression(string expression, bool isBalanced)
    {
        Console.WriteLine($"\n  {expression} >> {isBalanced}");
    }
}