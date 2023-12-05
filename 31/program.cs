internal class Program
{
    private static void Main(string[] args)
    {

        // Do While: 
        //  at least it will: This loop will execute the code block once, before checking if the condition is true

        // Example 1: Print Hello World 5 Times
        //Counter
        int i = 0;
        // افعل
        do
        {
            Console.WriteLine($"{i + 1}- Hello World");
            i++;
        }
        // طالما
        while (i < 5);

        // Example 2: Don't repeat ammar's name
        // Counter
        string name;
        do
        {
            Console.Write("Name: ");
            name = Console.ReadLine();
        }
        while (name != "ammar");
    }
}