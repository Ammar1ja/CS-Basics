internal class Program
{
    private static void Main(string[] args)
    {

        // Loops 
        // While
        /*
         Syntax
        Counter
         while (condition) 
            {
              // code block to be executed
              // Counter Increment or Decrement
            }
         */

        // Example 1: Infinit Loop
        while (true)
        {
            Console.WriteLine("Hello");
        }
        // Example 2: Print 5 times Hello World
        // Counter
        int i = 0;
        // while(condition)
        while (i < 5)
        {
            Console.WriteLine($"{i + 1}- Hello World");
            // Increment Or Decrement
            i++;
        }
        // Example 3: find average for n subjects
        Console.Write("Enter Number Of Subjects: ");
        double n = Convert.ToDouble(Console.ReadLine());
        int i = 0;
        double sum = 0;
        while (i < n)
        {
            Console.Write($"Enter Subject {i + 1}: ");
            double subject = Convert.ToDouble(Console.ReadLine());
            sum += subject;
            i++;
        }
        double answer = sum / n;
        Console.WriteLine($"Average: {answer}");

    }
}