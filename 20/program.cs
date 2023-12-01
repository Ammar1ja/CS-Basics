internal class Program

{
    private static void Main(string[] args)

    {
        // Arithmetic Operations

        int x = 30;
        int y = 10;
        int answer = 0;
        // Addition
        answer = x + y;
        Console.WriteLine("answer" + answer);
        // Subtraction
        answer = x - y;
        Console.WriteLine($"x - y = {answer}");
        // Multiplication
        answer = x * y;
        Console.WriteLine($"x * y = {answer}");
        // Division
        answer = x / y;
        Console.WriteLine($"x / y = {answer}");
        // Modulus
        answer = x % y;
        Console.WriteLine($"x % y = {answer}");

        // Increment ++
        // Pre: add then do
        // Post: do then add
        Console.WriteLine($"x= {x++}"); // 30 
        // x = 31
        Console.WriteLine($"x= {++x}"); // x = 32
        Console.WriteLine($"x = {++x}"); // x = 33
        Console.WriteLine($"x = {x++}"); // x = 33 
        // x=34
        Console.WriteLine($"x = {x}"); // x =34
        Console.WriteLine("--------------------------------------------------");
        // Decrement -- 
        Console.WriteLine($"x = {x--}"); // x = 34
        // x = 33
        Console.WriteLine($"x = {--x}"); // x = 32
        Console.WriteLine($"x = {--x}"); // x = 31
        Console.WriteLine($"x = {x--}"); // x = 31
        // x = 30
        Console.WriteLine($"x = {x}"); // x = 30
        Console.WriteLine("--------------------------------------------------");
    }
}