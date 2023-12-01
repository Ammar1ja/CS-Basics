internal class Program

{
    private static void Main(string[] args)

    {
        // Assignment Operations

        int x = 40, y = 20;
        x += 20; // x = x + 20 = 60
        // x = 60
        Console.WriteLine($"x:{x}");
        x -= 20; // x = x - 20 = 40
        // x = 40
        Console.WriteLine($"x:{x}");
        x /= y; // x = x / y = 2
        Console.WriteLine($"x:{x}");
        // x = 2
        x *= y; // x = x * y = 40
        // x = 40
        Console.WriteLine($"x:{x}");
        x %= y; // x = x % y = 0 // 40 % 20 =0
        Console.WriteLine($"x:{x}");

    }
}