internal class Program
{
    private static void Main(string[] args)
    {
        /* 
            Array:  are used to store multiple values 
            in a single variable, 
            instead of declaring separate variables for each value.
        */

        // Creation 
        string[] names;
        // Give the array values
        names = new string[] { "Ammar", "Ali", "Omar", "Ahmad", "Khalid", "X" };
        // creation + giving values at one step
        string[] cars = new string[] { "BMW", "LADA" };
        Console.WriteLine(names[2]);
    }
}