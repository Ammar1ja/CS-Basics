internal class Program
{
    private static void Main(string[] args)
    {
        // A method is a block of code which only runs when it is called.
        // They also called functions
        // Syntax: [return type] [function name](){}
        // num1 + num2 => double

        // Example 1: 
        // void: return nothing
        void printHello()
        {
            // block of code
            Console.WriteLine("Hello World");
        }
        // calling a method or function
        printHello();
    }
}