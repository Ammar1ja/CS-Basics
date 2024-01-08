internal class Program
{
    private static void Main(string[] args)
    {
        // Example 2:
        // say hello to name
        void helloTo(string name) // parameters: variables or containers
        {
            Console.WriteLine($"Hello {name}");
        }
        // calling method
        helloTo("Ammar"); // arguments: actual values
        helloTo("Amani");
    }
}