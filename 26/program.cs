internal class Program

{
    private static void Main(string[] args)

    {
        // Nested If
        if (100 > 60)
        {
            if (100 > 200) { }
            else
            {
                if (200 < 300)
                {
                    Console.WriteLine("if (200 < 300)");
                }
                else
                {
                    Console.WriteLine("else (200 < 300)");
                }
            }
        }
        else
        {
            Console.WriteLine("Outer else");
        }
    }
}