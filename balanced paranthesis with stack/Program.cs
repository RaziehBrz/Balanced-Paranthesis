using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a string of paranthesis : ");
        var inputString = Console.ReadLine();

        var result = checkBalance(inputString);
        Console.WriteLine(result);
    }
    static bool checkBalance(string inputString)
    {
        var isBalanced = false;
        var myStack = new Stack();

        if (inputString.Length == 0 || inputString.Length % 2 != 0 || inputString[0] == ')')
        {
        }
        else
        {
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '(')
                {
                    myStack.Push(inputString[i]);
                }
                else if (inputString[i] == ')')
                {
                    myStack.Pop();
                }
            }
            if (myStack.Count == 0)
            {
                isBalanced = true;
            }
        }
        return isBalanced;
    }
}