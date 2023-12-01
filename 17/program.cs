internal class Program

{
    private static void Main(string[] args)

    {
        // Concatenation
        // First Way
        int age = 32;
        string name = "Ammar";
        Console.WriteLine("Hello " + name + " your age is " + age);
        // Second Way
        Console.WriteLine("Hello {0} Your age is {1}", name, age);
        // interpolation
        Console.WriteLine($"Hello {name} your age is {age}");
    }
}