internal class Program
{
    private static void Main(string[] args)
    {
        // String Reverse
        // Ali -> ilA
        string name = "Ali";
        // 2 -> 1 -> 0
        // Last index always is [arrayName.length -1]
        for (int i = name.Length - 1; i >= 0; i--)
        {
            Console.Write(name[i]);
        }
    }
}