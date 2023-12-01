internal class Program

{
    private static void Main(string[] args)

    {
        // concatination
        string name = "Ali";
        int age = 20;
        // First Form Concat
        Console.WriteLine("Hello" + name + ", your age is " + age);
        // Second Form Concat
        Console.WriteLine("Hello {0}, your age is {1}", age, name); // الواسطة!
    }
}