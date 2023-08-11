internal class Program
{
    private static void Main(string[] args)
    {
        var isBalanced = false;
        int m = 0; // For '('
        int n = 0; // For ')'

        Console.WriteLine("Enter a string : ");
        var input = Console.ReadLine();

        if (input[0] != '(' || input.Length % 2 != 0)
        {
        }
        else
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    m++;
                }
                else if (input[i] == ')')
                {
                    n++;
                }
            }
            if (m == n)
            {
                isBalanced = true;
            }
        }
        Console.WriteLine(isBalanced);
    }
}